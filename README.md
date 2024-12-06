Aplikacja pozwala zagrać w grę przypominającą popularny teleturniej "Postaw na milion". Jest to aplikacja WinForms na .NET 6.0 wykorzystująca SQL Server.

Po naciśnięciu przycisku "START", użytkownik ma 15 sekund na wybranie jednej z dwóch kategorii. Jeśli nie wybierze żadnej, 
to po 15 sekundach zostanie wylosowana kategoria.
![image](https://github.com/user-attachments/assets/a4de5c93-30aa-4579-a788-79ce5cacd10f)
Najpierw wyświetli się ekran informujący użytkownika o tym, którą kategorię wybrał, a następnie pojawi się ekran z samymi odpowiedziami.
![image](https://github.com/user-attachments/assets/048957f2-3e69-4980-ab84-b6eaa514b0b2)
Później pokaże się ekran z pytaniem i odpowiedziami. Po pewnym czasie na tym ekranie wystartuje minutnik i pojawią się przyciski z "-" i "+" umożliwiające rozłożenie pieniędzy, które użytkownik ma w swojej puli. W pytaniach 1-4 
użytkownik widzi 4 propozycje odpowiedzi, w pytaniach 5-7 przedstawione są 3 propozycje odpowiedzi, a w ostatnim 8. pytaniu znajdują się 2 propozycje odpowiedzi.
![image](https://github.com/user-attachments/assets/81eb01dc-d362-4b5f-b3ef-1f353fb552fe)
![image](https://github.com/user-attachments/assets/a6e95838-8875-4ce2-816d-4fc7c5e62d1e)
Podczas każdej rundy blokowana jest możliwość umieszczenia pieniędzy na ostatniej odpowiedzi, bo jedno pole z odpowiedzią zawsze pozostać puste. 
![image](https://github.com/user-attachments/assets/acf7c59a-0a51-4387-a449-acb6233ce77e)
Na rozłożenie pieniędzy użytkownik ma 1 minutę, ale po rozłożeniu całej kwoty pojawia się przycisk umożliwiający wyłączenie minutnika i szybsze uzyskanie informacji o tym, która odpowiedź była prawidłowa. 
![image](https://github.com/user-attachments/assets/eb18c366-64c2-41f1-b9a3-a70a1ee97b99)
Kwota, która nie została rozłożona, przepada. Po pewnym czasie od zatrzymania minutnika, na zielono zostaje podświetlona prawidłowa odpowiedź, a pozostałe oznaczone są kolorem czerwonym.
![image](https://github.com/user-attachments/assets/4c83398f-d948-4138-ab26-2ec586c7b75a)
Następnie pojawia się ekran podsumowujący dotychczasową grę. Znajduje się na nim infomacja, o kwotach, jakie użytkownik utracił podczas poszczególnych rund.
![image](https://github.com/user-attachments/assets/2457c2f5-bc6d-45a0-9d22-dedf1d2222a9)
Po pewnym czasie aplikacja przechodzi do ekranu wyboru następnej kategorii pytania. Gra kończy się, jeśli użytkownik straci wszystkie pieniądze lub po 8. pytaniu pozostanie mu jakakolwiek kwota. Pojawia się wtedy ekran informujący 
użytkownika o pożarce lub sukcesie. Ekran ten zawiera także przycisk pozwalający na rozpoczęcie nowej gry.
![image](https://github.com/user-attachments/assets/91aad249-e282-4890-995f-f0adaae6d49a)


