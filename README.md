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
