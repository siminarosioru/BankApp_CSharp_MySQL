# BankApp_CSharp_MySQL

# User Interface Design
- fill in the 2 empty fields (Nume utilizator, Parola) ->
- then press the "Autentificare" button
![](the%20Bank%20Application%20interface.png)
- if that person has the "administrator" role => open the "Adaugare Utilizator" interface ->
- fill in the 4 empty fields (Utilizator, Parola, Nume, Prenume) ->
- then press the "Adaugare utilizator" button ->
- then press the "Actualizare date" button and the new record is present in the data base ->
- then press the "Stergere campuri" button to delete the fields and you can write a new record
![](photo%20with%20the%20Adaugare%20Utilizator%20interface.png)
- if that person has the "banca" role => open the "Clienti" interface ->
- fill in the 5 empty fields (Nume, Prenume, CNP, Adresa, Telefon) ->
- then press the "Adaugare" button ->
- then press the "Actualizare date" button and the new record is present in the data base ->
- when you want to modify a record -> select the line to modify -> then press the "Modificare" button and then the "Actualizare date" button
- when you want to delete a record -> select the line to delete -> then press the "Stergere" button and then the "Actualizare date" button
- the last button in the "Clienti" interface is the "Adaugare cont" button -> 
- when press the "Adaugare cont" button -> open the "Adaugare Cont" interface
![](photo%20with%20the%20Clienti%20interface.png)
- when the "Adaugare Cont" interface is opened ->
- select the line to which you want to add a new account in euros or ron ->
- then fill in the rest empty fields (Numar, Tip cont, Sold) ->
- then press the "Adaugare cont" button ->
- then press the "Actualizare date" button and the record is present in the data base
![](photo%20with%20the%20Adaugare%20Cont%20interface.png)

# Description
- the tool used is Visual Studio 2019, Windows Forms App (.NET Framework)
- the application is realised with .NET Framework using the C# programming language.
- I used MySQL Workbench for the "bankapp_mysql_db" data base.

