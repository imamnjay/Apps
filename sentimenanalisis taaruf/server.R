library(shiny)
library(shinydashboard)
shinyServer(function(input, output, session){
    #untuk menampilkan dataset
    output$dataset <- renderDataTable({
        read.csv("data_tweets.csv")})
    output$tolower <- renderDataTable({
        read.csv("tolower.csv")})
    output$normalisasi <- renderDataTable({
        read.csv("normalisasi.csv")})
    output$Filtering <- renderDataTable({
        read.csv("filtering.csv")})
    output$katabaku <- renderDataTable({
        read.csv("katabaku.csv")})
    output$stopwordremoval <- renderDataTable({
        read.csv("stopword.csv")})
    output$stemming <- renderDataTable({
        read.csv("stemming.csv")})
    output$leksikon <- renderDataTable({
        read.csv("table_finalfix2.csv")})
    output$pengujian <- renderDataTable({
        read.csv("table_finalfix.csv")})

})
