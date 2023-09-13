library(devtools)
library(textclean)
library(dplyr)
library(tm)
library(tokenizers)
library(katadasaR)
library(corpus)

tweets <- read.csv("data_tweets.csv")

tweets <- tweets$text %>% 
  as.character()
head(tweets)

#case folding
tweets <- tolower(tweets)
write.csv(tweets,'tolower.csv', row.names = F)

#Normalisasi Data Tweet
tweets <- tweets %>% 
  replace_emoji(.) %>% 
  replace_html(.) %>%
  replace_url(.)

tweets <- tweets %>% 
  replace_tag(tweets, pattern = "@([A-Za-z0-9_]+)",replacement="") %>%  # remove mentions
  replace_hash(tweets, pattern = "#([A-Za-z0-9_]+)",replacement="")      # remove hashtags

write.csv(tweets,'normalisasi.csv', row.names = F)

#Filtering 

tweets <- strip(tweets)

tweets <- tweets[!duplicated(tweets)]

write.csv(tweets,'filtering.csv', row.names = F)

#Mengubah Kata Baku
spell.lex <- read.csv("kamus_slang.csv")
tweets <- replace_internet_slang(tweets, slang =
                                   paste0("\\b",
                                          spell.lex$slang, "\\b"),
                                 replacement = spell.lex$formal, ignore.case = TRUE)
write.csv(tweets,'katabaku.csv', row.names = F) 


#Stopword
stopword_bindo <- read.csv("stp.csv", header = FALSE)
stopword_bindo <- as.character(stopword_bindo$V1) 
stopword_bindo <- c(stopword_bindo, stopwords()) 
tweets <- removeWords(tweets, stopword_bindo)
tweets <- stripWhitespace(tweets)
write.csv(tweets,'stopwordfix.csv', row.names = F)

tweets <- read.csv('stopwordfix.csv')
tweets <- tweets$x %>%
  as.character()
head(tweets)

#stemming
stemming <- function(x){
  paste(lapply(x, katadasar),collapse = " ")}

tweets <- lapply(tokenize_words(tweets[]), stemming)

tweets <- as.character(tweets)

write.csv(tweets,'stemming.csv', row.names = F)
