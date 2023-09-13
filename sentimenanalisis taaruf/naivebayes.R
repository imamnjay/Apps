#Klasifikasi Data dengan Naive Bayes Classifier
datalexicon <- read.csv('table_finalfix2.csv')

positif_or_negatif <- read.csv('table_finalfix2.csv')
str(positif_or_negatif)
View(positif_or_negatif)
which(!complete.cases(positif_or_negatif))
table(positif_or_negatif$Summary)
prop.table(table(positif_or_negatif$Summary))
positif_or_negatif$Text <- as.character(positif_or_negatif$Text)
positif_or_negatif$Textlength <- nchar(positif_or_negatif$Text)

library("tm")
taaruf_corpus <- Corpus(VectorSource(positif_or_negatif$Text))
print(taaruf_corpus)
inspect(taaruf_corpus)

dtm_tweets <- DocumentTermMatrix(VCorpus(VectorSource(datalexicon$Text)))
inspect(dtm_tweets)

dtm_tweets_latih <- dtm_tweets[1:3587, ]
dtm_tweets_uji <- dtm_tweets[3588:5124, ]

label_sentimen_latih <- datalexicon[1:3587, ]$Summary
label_sentimen_uji <- datalexicon[3588:5124, ]$Summary

konversi_jumlah <- function(x){
  x <- ifelse(x > 0, "Ada", "TAda")
}

sentimen_latih <- apply(dtm_tweets_latih,
                        MARGIN = 2, konversi_jumlah)

sentimen_uji <- apply(dtm_tweets_uji,
                      MARGIN = 2, konversi_jumlah)

#melatih data training
library(e1071)
pengklas_sentimen <-naiveBayes(sentimen_latih, label_sentimen_latih)
pengklas_sentimen <-naiveBayes(sentimen_uji, label_sentimen_uji)

pengklas_sentimen$apriori

pengklas_sentimen$tables[1]

prediksi_sentimen <- predict(pengklas_sentimen, sentimen_latih)
prediksi_sentimen <- predict(pengklas_sentimen, sentimen_uji)

table(prediksi_sentimen)

#hasil dalam bentuk tabel
library(gmodels)
CrossTable(prediksi_sentimen, label_sentimen_uji,
           prop.chisq = F,prop.t = F,
           dnn = c('terprediksi' , 'manual'))
CrossTable(prediksi_sentimen, label_sentimen_latih,
           prop.chisq = F,prop.t = F,
           dnn = c('terprediksi' , 'manual'))

#mengetahui akurasi perhitungan menggunakan confusion matrix
library(caret)
conf.mat <- confusionMatrix(prediksi_sentimen, label_sentimen_latih )
conf.mat <- confusionMatrix(prediksi_sentimen, label_sentimen_uji )


table(prediksi_sentimen)

conf.mat

View('prediksi_sentimen')
View('table_finalfix2.csv')


#Histogram
library(lattice)
histogram_negatif <- which(positif_or_negatif$Summary =="Negative")
histogram_positif <- which(positif_or_negatif$Summary =="Positive")
histogram_netral <- which(positif_or_negatif$Summary =="Netral")
hist1 <- hist(positif_or_negatif$Textlength,  main="Histogram Berdasarkan Panjang Karakter", xlab = "Panjang_Karakter", col = "orange")
hist2 <- hist(histogram_negatif ,main="Histogram Data Sentimen Negatif",col = "red")
hist3 <- hist(histogram_positif ,main="Histogram Data Sentimen Positif",col = "green")
hist4 <- hist(histogram_netral ,main="Histogram Data Sentimen Netral",col = "darkmagenta")

View(datalexicon)

#Diagram Pie
library(plotrix)
mytable <- table(label_sentimen_latih)
lbls <- paste(names(mytable), "\n", mytable, sep="")
pie3D(mytable, labels =lbls, radius=0.8,explode=0.3,shade=0.9, theta=0.4, main="Diagram Pie Data Latih")
pie(mytable, labels = lbls, main="Diagram Pie Data Latih")
mytable2 <- table(label_sentimen_uji)
lbls <- paste(names(mytable2), "\n", mytable2, sep="")
pie3D(mytable2, labels =lbls, radius=0.8,explode=0.3,shade=0.9, theta=0.4, main="Diagram Pie Data Uji")
pie(mytable2, labels = lbls, main="Diagram Pie Data Uji")
mytable3 <- table(prediksi_sentimen)
lbls <- paste(names(mytable3), "\n", mytable3, sep="")
pie3D(mytable3, labels =lbls, radius=0.8,explode=0.3,shade=0.9, theta=0.4, main="Diagram Pie Hasil Klasifikasi Data Uji")
pie(mytable3, labels = lbls, main="Diagram Pie Hasil Klasifikasi Data Uji")

#WordCloud
negatif_cloud <- which(positif_or_negatif$Summary =="Negative")
positif_cloud <- which(positif_or_negatif$Summary =="Positive")

library(wordcloud)
library(RColorBrewer)
wordcloud(words = taaruf_corpus[negatif_cloud], min.freq = 3, max.words = 300, random.order = FALSE, rot.per = 0.35, colors = brewer.pal(8,"Dark2"), main="Wordcloud Negatif")
wordcloud(words = taaruf_corpus[positif_cloud], min.freq = 5, max.words = 300, random.order = FALSE, rot.per = 0.35, colors = brewer.pal(8,"Dark2"), main="Wordcloud Positif")
