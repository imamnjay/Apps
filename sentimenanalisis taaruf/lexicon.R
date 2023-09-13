library(devtools)
library(tm)
library(stringr)
library(katadasaR)
library(NLP)
library(ggplot2)
library(reshape)
library(corpus)
library(dplyr)


pos.words = scan("positive.tsv", what='character', comment.char=';') 
neg.words = scan("negative.tsv", what='character', comment.char=';')

coba_tweets <- read.csv('stemming.csv')
coba_tweets <- as.character(coba_tweets$x)

score.sentiment = function(sentences, pos.words, neg.words, .progress='none')
  
{
  require(plyr)
  require(stringr)
  list=lapply(sentences, function(sentence, pos.words, neg.words)
  {
    require(plyr)
    require(stringr)
    require(katadasaR)
    sentence = gsub('[[:punct:]]',' ',sentence)
    sentence = gsub('[[:cntrl:]]','',sentence)
    sentence = gsub('\\d+','',sentence)
    sentence = gsub('\n','',sentence)
    
    sentence = tolower(sentence)
    word.list = str_split(sentence, '\\s+')
    words = unlist(word.list)
    words = sapply(words, katadasaR)
    pos.matches = match(words, pos.words)
    neg.matches = match(words, neg.words)
    pos.matches = !is.na(pos.matches)
    neg.matches = !is.na(neg.matches)
    pp=sum(pos.matches)
    nn=sum(neg.matches)
    score = sum(pos.matches) - sum(neg.matches)
    list1=c(score, pp, nn)
    return (list1)
  }, pos.words, neg.words)
  score_new=lapply(list, `[[`, 1)
  pp1=score=lapply(list, `[[`, 2)
  nn1=score=lapply(list, `[[`, 3)
  
  scores.df = data.frame(score=score_new, text=sentences)
  positive.df = data.frame(Positive=pp1, text=sentences)
  negative.df = data.frame(Negative=nn1, text=sentences)
  
  list_df=list(scores.df, positive.df, negative.df)
  return(list_df)
}

result = score.sentiment(coba_tweets, pos.words, neg.words)

#Creating a copy of result data frame
test1=result[[1]]
test2=result[[2]]
test3=result[[3]]

#Creating three different data frames for Score, Positive and Negative
#Removing text column from data frame
test1$text=NULL
test2$text=NULL
test3$text=NULL

#Storing the first row(Containing the sentiment scores) in variable q
q1=test1[1,]
q2=test2[1,]
q3=test3[1,]
qq1=melt(q1, ,var='Score')
qq2=melt(q2, ,var='Positive')
qq3=melt(q3, ,var='Negative') 
qq1['Score'] = NULL
qq2['Positive'] = NULL
qq3['Negative'] = NULL

#Creating data frame
table1 = data.frame(Text=result[[1]]$text, Score=qq1)
table2 = data.frame(Text=result[[2]]$text, Score=qq2)
table3 = data.frame(Text=result[[3]]$text, Score=qq3)

#Merging three data frames into one
table_final=data.frame(Text=table1$Text, Positive=table2$value, Negative=table3$value, Score=table1$value)

#table_final$Summary <- ifelse(table_final$Score < 0, "Negative", ifelse(table_final$Score > 0, "Positive","Netral"))

table_final$Summary <- ifelse(table_final$Score < 0, "Negative","Positive")

table_bersih = table_final[!table_final$Score == 0,]

positif = sum(table_final$Score > 0)
negatif = sum(table_final$Score < 0)
netral = sum(table_final$Score == 0)

#positive percen
PosPc = table_final$Positive
negPC = table_final$Negative
table_final$PosPercent = PosPc/ (PosPc+negPC)
pp = table_final$PosPercent
pp[is.nan(pp)] <- 0
table_final$PosPercent = pp

#negative percen
table_final$NegPercent = negPC/ (PosPc+negPC)
nn = table_final$NegPercent
nn[is.nan(nn)] <- 0
table_final$NegPercent = nn

View(table_final)

write.csv(table_final,'table_finalfix.csv', row.names = F)