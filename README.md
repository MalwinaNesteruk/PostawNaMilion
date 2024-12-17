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
Podczas każdej rundy blokowana jest możliwość umieszczenia pieniędzy na ostatniej odpowiedzi, bo jedno pole z odpowiedzią zawsze musi pozostać puste. 
![image](https://github.com/user-attachments/assets/acf7c59a-0a51-4387-a449-acb6233ce77e)
Na rozłożenie pieniędzy użytkownik ma 1 minutę, ale po rozłożeniu całej kwoty pojawia się przycisk umożliwiający wyłączenie minutnika i natychmiastowe sprawdzenie odpowiedzi. 
![image](https://github.com/user-attachments/assets/eb18c366-64c2-41f1-b9a3-a70a1ee97b99)
Kwota, która nie została rozłożona, przepada. Po chwili od zatrzymania minutnika, na zielono zostaje podświetlona prawidłowa odpowiedź, a pozostałe oznaczone są kolorem czerwonym.
![image](https://github.com/user-attachments/assets/4c83398f-d948-4138-ab26-2ec586c7b75a)
Następnie pojawia się ekran podsumowujący dotychczasową grę. Znajduje się na nim infomacja, o kwotach, jakie użytkownik utracił podczas poszczególnych rund.
![image](https://github.com/user-attachments/assets/2457c2f5-bc6d-45a0-9d22-dedf1d2222a9)
Po pewnym czasie aplikacja przechodzi do ekranu wyboru następnej kategorii pytania. Gra kończy się, jeśli użytkownik straci wszystkie pieniądze lub po 8. pytaniu pozostanie mu jakakolwiek kwota. Pojawia się wtedy ekran informujący użytkownika o porażce lub sukcesie. Ekran ten zawiera także przycisk pozwalający na rozpoczęcie nowej gry.
![image](https://github.com/user-attachments/assets/91aad249-e282-4890-995f-f0adaae6d49a)

### Przykładowe pytania:

| id | kategoria | pytanie | odpowiedzA | odpowiedzB | odpowiedzC | odpowiedzD | czyWolne |
| --- | --- | --- | --- | --- | --- | --- | ---|
| 1  | dobre wychowanie | Zachowanie niezgodne z przyjętymi zwyczajami towarzyskimi to inaczej:                                         | faux pas                | bon mot                  | fondue                     |  chapeau bas                    | 0 |
| 2  | tradycje         | Bukty to tradycyjny przysmak wigilijny przygotowywany przez:                                                  | Podhalan                | Kaszubów                 | Kurpiów                    |  Ślązaków                       | 0 |
| 3  | rośliny          | Którą przyprawę otrzymuje się z kłącza, czyli podziemnego pędu rośliny?                                       | imbir                   | rozmaryn                 | cynamon                    |  szafran                        | 0 |
| 4  | taniec           | 'Czy pozwoli panna Krysia? – młody ułan pyta, zapraszając partnerkę, choć poranek świta' do jeszcze jednego:  | mazura                  | poloneza                 | walca                      |  tanga                          | 1 |
| 5  | polityka         | Kto w 1995 r. powiedział, że 'Prawdziwego mężczyznę poznaje się po tym, jak kończy, a nie jak zaczyna'?       | Leszek Miller           | Aleksander Kwaśniewski   | Marian Krzaklewski         |  Lech Wałęsa                    | 0 |
| 6  | dziedzictwo      | Która starówka nie jest wpisana na Listę Światowego Dziedzictwa UNESCO?                                       | w Lublinie              | w Warszawie              | w Toruniu                  |  w Zamościu                     | 0 |
| 7  | jedzenie         | Badacze porównali, jak mieszkańcy różnych krajów spędzają czas. Kto się najbardziej spieszy przy posiłkach?   | Amerykanie              | Brytyjczycy              | Francuzi                   |  Norwegowie                     | 1 |
| 8  | głos             | Którym głosem da się zaśpiewać najwyższe dźwięki?                                                             | sopranem                | altem                    | tenorem                    |  basem                          | 0 |
| 9  | imię             | Jakie było prawdziwe imię Violetty Villas?                                                                    | Czesława                | Jolanta                  | Stanisława                 |  Helena                         | 1 |
| 10 | atrakcje         | Które muzeum może się pochwalić największą liczbą zwiedzających rocznie?                                      | Luwr                    | Chińskie Muzeum Narodowe | Muzeum Brytyjskie          |  The Metropolitan Museum of Art | 0 |
| 11 | najstarsze       | Pierwsza pizzeria w Polsce rozpoczęła działalność w połowie lat 70. XX. Gdzie?                                | w Słupsku               | w Radomiu                | w Krakowie                 |  w Warszawie                    | 1 |
| 12 | unik             | Osoby na diecie bezglutenowej unikają potraw zawierających:                                                   | pszenicę                | ryż                      | kukurydzę                  |  proso                          | 0 |
| 13 | magia świąt      | Brytyjczycy wierzą, że szczególne szczęście czeka w następnym roku tego, kto podczas świąt Bożego Narodzenia: | całował się pod jemiołą | zjadł najwięcej makowca  | zobaczył pierwszą gwiazdkę |  upuścił widelec                | 0 |
| 14 | pieniądze        | Na liście 'Forbesa' najlepiej zarabiających aktorek 2020 r. pierwsze miejsce zajęła:                          | Sofia Vergara           | Meryl Streep             | Angelina Jolie             |  Gal Gadot                      | 1 |
| 15 | muzyka           | Z którego z tych naturalnych materiałów wykonywano wczesne płyty gramofonowe?                                 | szelak                  | szylkret                 | heban                      |  kość słoniowa                  | 0 |
| 16 | kolory           | Jakie barwy ma flaga esperancka?                                                                              | zieloną i białą         | czerwoną i żółtą         | niebieską i białą          |  niebieską i żółtą              | 0 |
| 17 | więcej-lepiej?   | Kto z nich napisał i wydał najwięcej powieści?                                                                | Remigiusz Mróz          | Szczepan Twardoch        | Katarzyna Grochola         |  Wojciech Chmielarz             | 1 |
| 18 | kraj             | Nie biorąc pod uwagi Nepalu i Bhutanu, krajem o największej na świecie średniej wysokości n.p.m. jest:        | Tadżykistan             | Ukraina                  | Kirgistan                  |  Boliwia                        | 0 |
| 19 | na sprzedaż      | 'Niemiec płakał, jak sprzedawał' – zapewniają handlarze:                                                      | używanych samochodów    | świeżych warzyw          | akcji i obligacji          |  dzieł sztuki                   | 0 |
| 20 | tradycyjny ubiór | Tradycyjny ubiór kobiecy w Indiach, długi kupon tkaniny upięty wokół talii i przerzucony przez ramię, to:     | sari                    | dhoti                    | pareo                      |  sarong                         | 0 |


Jest też druga aplikacja umożliwiająca dodawanie pytań do bazy danych. 
![image](https://github.com/user-attachments/assets/38cbc04e-3ff3-4920-8b40-70cd52c1f1e6)
Należy uzupełnić wszystkie pola i kliknąć przycisk 'Dodaj do bazy pytań'. Gdy pytanie zostanie poprawne dodane do bazy, to użytkownik zobaczy komunikat 'Pytanie zostało dodane do bazy.'. Jeśli którekolwiek z pól zostanie wypełnione w nieprawidłowy sposób, to pojawi się okno informujące użytkownika na czym polega błąd.
