#Intro shinydashboard package
#Add pages for menu items
#install.packages("shinydashboard")
#Load required packages

library(shiny)
library(shinydashboard)
shinyUI(dashboardPage(title = "Analisis Sentimen Konsep Menikah Melalui Taaruf Pada Twitter", skin = "blue",
                      dashboardHeader(title = "Analisis Sentimen Konsep Menikah Melalui Konsep Taaruf Pada Twitter", titleWidth = 700),
                      dashboardSidebar(sidebarMenu(menuItem(text ="Menu Utama", tabName = "dashboard", icon=icon("dashboard")),

                                                   menuItem(text ="Pre-processing"),
                                                   menuSubItem("Dataset", tabName = "dataset", icon=icon("database")),
                                                   menuSubItem("Case Folding", tabName = "tolower", icon=icon("text-size", lib="glyphicon")),
                                                   menuSubItem("Normalisasi", tabName = "normalisasi",  icon=icon("exclamation-sign", lib="glyphicon")),
                                                   menuSubItem("Filtering", tabName = "Filtering", icon=icon("erase", lib="glyphicon")),
                                                   menuSubItem("Ubah Kata Baku", tabName = "katabaku", icon=icon("tasks", lib="glyphicon")),
                                                   menuSubItem("Stopword", tabName = "stopwordremoval", icon=icon("trash", lib="glyphicon")),
                                                   menuSubItem("Kata Dasar/Stemming", tabName = "stemming", icon=icon("scissors", lib="glyphicon")),
                                                   menuSubItem("Klasifikasi Leksikon", tabName = "leksikon", icon=icon("print", lib="glyphicon")),
                                                   menuItem("Akurasi dan Visualisasi", tabName="naivebayes"))),

                      dashboardBody(
                          #within tabitems(), define the pages for sidebar menu items
                          tabItems( tabItem(tabName ="dashboard",
                                            h2("Selamat Datang di Aplikasi Analisis Sentimen Pengguna Twitter Mengenai Taaruf dengan Naive Bayes Classifier dan Lexicon Based", align="center"),
                                            hr(), h3("Dibuat Oleh :", align="center"),
                                            hr(),
                                            h4("Imam Mahdi Nashif", align="center"),
                                            h4("13116461", align="center"), tags$img(src='imam.png', height=200, width=200, style="display: block;margin-left:auto;margin-right:auto;
class:rounded mx-auto d-block")),

                                    tabItem(tabName = "dataset", dataTableOutput("dataset")),
                                    tabItem(tabName = "tolower", dataTableOutput("tolower")),
                                    tabItem(tabName = "normalisasi", dataTableOutput("normalisasi")),
                                    tabItem(tabName = "Filtering", dataTableOutput("Filtering")),
                                    tabItem(tabName = "katabaku", dataTableOutput("katabaku")),
                                    tabItem(tabName = "stopwordremoval", dataTableOutput("stopwordremoval")),
                                    tabItem(tabName = "stemming", dataTableOutput("stemming")),
                                    tabItem(tabName = "leksikon", dataTableOutput("pengujian")),
                                    tabItem(tabName = "naivebayes", tabsetPanel(type="tab",
                                                                                tabPanel("Hasil Testing", dataTableOutput("leksikon")),
                                                                                tabPanel("Hasil Akurasi", h3("Hasil Akurasi Menggunakan Naive Bayes Classifier :", align="center"),
                                                                                         hr(),
                                                                                         h1("90.76%", align="center"), hr()),
                                                                                tabPanel("Histogram",
                                                                                         tags$img(src="Rhisto_Panjang_Karakter.png"),
                                                                                         tags$img(src="Rhisto_Sentimen_Positif.png"),
                                                                                         tags$img(src="Rhisto_Sentimen_Netral.png"),
                                                                                         tags$img(src="Rhisto_Sentimen_Negatif.png"),

                                                                                         hr()),

                                                                                         tabPanel("Diagram Pie",
                                                                                                  tags$img(src="Rpie3D_Data_Latih.png"),hr(),
                                                                                                  tags$img(src="Rpie3D_Data_Uji.png"),
                                                                                                  tags$img(src="Rpie3D_Klasifikasi_DataUji.png"),hr()),

                                                                                                  tabPanel("Wordcloud",
                                                                                                           tags$img(src="wordcloud_positif.png"),
                                                                                                           tags$img(src="wordcloud_negatif.png"))
                                                                                         ))
                                    ))))
