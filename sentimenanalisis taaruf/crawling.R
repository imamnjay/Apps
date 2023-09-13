install.packages("devtools")
devtools::install_github("r-lib/devtools")
devtools::install_github("nurandi/katadasaR")
install.packages("rtweet")
install.packages("tokenizers")
install.packages("tm")
install.packages("textclean")

library(devtools)
library(rtweet)
library(tm)
library(textclean)
library(tokenizers)
library(katadasaR)

#autentifikasi token
token <- create_token(
  app = "sentimentaaruf",
  consumer_key = "x7DHmSgXqY0hXs8k5RRjGXlvp",
  consumer_secret = "VjWnKxD1QUAo1R3OypaQvaa3Shz9Yq4q0JYFOjYtzf7hWo89aS",
  access_token ="1854608480-c5989ZzW9nfwiJ0WDFRxkaK9xeWmpoMG1Ul6MME",
  access_secret = "IeQhBH2eB4VYiEeAu8oNUXyjNcuoIBqG78Rxlhmi18Fwz"
)
identical(token, get_token())


datatweet <- search_tweets(
  "taaruf OR ta'aruf-filter:links " , n =10000,
  include_rts = TRUE, lang="id", tweet_mode ="extended",
)

save_as_csv(datatweet, "data_tweets", prepend_ids = TRUE, na = "", 
            fileEncoding = "UTF-8")

