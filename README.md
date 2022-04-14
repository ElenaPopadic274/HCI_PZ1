# HCI_PZ1

Kreirana je WPF aplikacija koja predstavlja jednostavan informacioni sistem. 
 
Informacioni sistem upravlja objektima samo jedne klase. Klasa sadrži jedno polje koje je brojevnog tipa, jedno tekstualno, jedno koje predstavlja datum, 
jedno koje će služiti za prikaz slike i jedno koje će referencirati tekstualni fajl. 

Sama WPF aplikacija na glavnom prozoru ima tabelu koja prikazuje sliku i vrednosti najvažnijih polja za razlikovanje objekata. Svaki red u tabeli sa objektima ima 
i tri dugmeta od kojih je jedno za poziv prozora za pregled konkretnog objekta, drugo služi za poziv prozora za izmenu parametara odabranog objekta, a treće 
za brisanje konkretnog objekta. Pored tabele na glavnom prozoru se nalaze dugmad za dodavanje novog objekta i dugme za izlaz iz aplikacije. Klik na dugme 
za dodavanje novog objekta poziva prozor za dodavanje novog objekta gde je moguće uneti vrednosti za sva polja klase objekta. 

Kod oba prozora je implementirana validaciju svih polja. Takodje je implementiran DataBinding u okviru tabele. Prilikom izmene i dodavanja novog objekta, jedno polje 
za unos je realizovano kao RichTextBox. Implementirane su opcije “Bold”, "Italic", "Underline", "promena boje teksta", “promena fonta”, i "promena veličine slova".

Takodje pored ovih opcija, na RichTextBox je dodan status bar i u njemu se prikazuje broj reči u RichTextBox-u. 

Aplikacija ima iscrtan proizvoljan oblik prozora.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------
A WPF application was created that represents a simple information system. 

The information system manages objects of only one class. The class contains one field that is of numeric type, one that is textual, one that represents the date, 
one that will be used to display the image, and one that will reference the text file. 

The WPF application itself has a table on the main window that shows the image and values of the most important fields for distinguishing objects. Each row in the table with objects also has three buttons, one of which is for calling the window for viewing a specific object, the other is for calling the window for changing the parameters of the selected object, and the third for deleting a specific object. Next to the table in the main window, there are buttons for adding a new object and a button for exiting the application. Clicking the Add New Object button calls up the Add New Object window where values for all object class fields can be entered.

Validation of all fields is implemented in both windows. DataBinding within the table was also implemented. When modifying and adding a new object, one input field is implemented as a RichTextBox. The options "Bold", "Italic", "Underline", "change text color", "change font", and "change font size" have been implemented. 

Also in addition to these options, a status bar has been added to the RichTextBox and it shows the number of words in the RichTextBox. 

The application has drawn an arbitrary window shape.
