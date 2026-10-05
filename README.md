# My First AR Project 

Un proiect de Realitate Augmentată (AR) realizat în Unity folosind Vuforia Engine. Aplicația recunoaște obiectele și randează deasupra lor modele 3D (Centauri). 

Când cutiile sunt aduse una lângă cealaltă, scriptul calculează distanța fizică și declanșează automat o animație de atac (Attack) între cele două creaturi.

## Video Demo
https://github.com/user-attachments/assets/9dda59d4-b7cf-41b3-b491-a159eba06f1a


## 🛠Tehnologii folosite
* **Unity 3D** (versiunea 6.3 LTS)
* **Vuforia Engine** (pentru Image Tracking)
* **C#** (pentru logica de calcul a distanței și controlul Animatorului)

## Funcționalități principale
* **Multiple Image Tracking:** Urmărire simultană a două obiecte distincte.
* **Măsurarea distanței în timp real:** Calculul proximității în spațiul 3D.
* **Animații dinamice:** Tranziție fluidă de la starea de repaus (`Idle`) la starea de atac (`Attack`) pe baza proximității.
