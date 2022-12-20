# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

Doughnut

Herzig, Angelov, Eser, *Burlet*

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | Projektdoku IPE gmacht|
|       | 0.0.2|Wir haben uns mit WinForms befasst. Sind dabei aber meist kläglich gescheitert.|
|       |0.0.3|wir haben versucht einen 2D array zu visualisieren, was nicht funktioniert hat.|
||0.0.4|Wir haben es mit buttons gemacht und haben ein 4x4 bauerschach gemacht.|
||1.0.0|Wir sind fertig mit dem 4x4 Bauerschach, haben die Projektdokumentation fertiggestellt und den/die Lernbericht(e) geschrieben.|

## 1 Informieren




### 1.1 Ihr Projekt

Unser Projekt ist es, ein Schach zu programmieren, welches man zu zweit spielen kann.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
|01|Muss|Qualität|Als User möchte ich ein Spielbrett sehen.|
|02|Muss|Funktion|Als User möchte ich, dass die Schachfiguren am richtigen Ort spawnen.|
|03|Muss|Funktion|Als User möchte ich, dass ich die Spielfiguren richtig bewegen kann.|
|04|Muss|Funktion|Als User möchte ich, dass ich gegnerfiguren, wenn ich auf sie drauf gehe, aus dem Spiel nehme|
|05|Muss|Qualität|Als User möchte ich, dass die Spielfiguren die richtige Textur haben.|
|06|Muss|Rand|Als User möchte ich, nach den richtigen Schachregeln spielen.|
|07|Kann|Funktion|Als User möchte ich, einstellen können, ob ich nach Zeit spielen möchte.|
|08|Kann|Qualität|Als User möchte ich angezeigt bekommen, wo ich mit meiner Figur hinfahren kann.|
|09|Muss|Funktion|Als User möchte ich, mehr als eine Runde spielen.|
|10|Kann|Funktion|Als User möchte ich, eine Spielzug rückgänig machen können.|


✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
|01.1|Programm wurde gestartet.| |Schachbrett|
|02.1|Programm wurde gestartet.| |Schachbrett mit Figuren am richtigen Ort.|
|03.1|Programm wurde gestartet, Bauer angeklickt|Aufleuchtendes Feld angeklickt|Bauer verschwindet auf vorherigem Feld und ist auf dem neuen Feld.|
|03.2|Programm wurde gestartet, Bauer angeklickt|Nicht aufleuchtendes Feld angeklickt|Bauer bleibt stehen, fehlermeldung "Dieser Spielzug ist nicht möglich"|
|03.3|Programm wurde gestartet, Turm befindet sich auf Feld A5, Turm angeklickt|Aufleuchtendes Feld angeklickt|Turm verschwindet auf vorherigem Feld und ist auf dem neuen Feld.|
|03.4|Programm wurde gestartet|Turm angeklickt|Diese Figur kann nicht bewegt werden.|
|03.5|Programm wurde gestartet, Turm befindet sich auf Feld A5, Turm angeklickt|Nichtaufleuchtendes Feld angeklickt|Turm bleibt stehen, fehlermeldung "Dieser Spielzug ist nicht möglich".|
|03.6|Programm wurde gestartet, Springer befindet sich auf Feld 3H, Springer angeklickt|Aufleuchtendes Feld angeklickt|Springer verschwindet auf vorherigem Feld und ist auf dem neuen Feld.|
|03.7|Programm wurde gestartet|Springer angeklickt|Diese Fiegur kann nicht bewegt werden.|
|03.8|Programm wurde gestartet, Springer befindet sich auf Feld 3H, Springer angeklickt|Nichtaufleuchtendes Feld angeklickt|Springer bleibt stehen, fehlermeldung "Dieser Spielzug ist nicht möglich".|
|03.9|Programm wurde gestartet, Pferd befindet sich auf Feld 3C, Turm angeklickt|Aufleuchtendes Feld angeklickt|Pferd verschwindet auf vorherigem Feld und ist auf dem neuen Feld.|
|03.10|Programm wurde gestartet|Pferd angeklickt|Diese Fiegur kann nicht bewegt werden.|
|03.11|Programm wurde gestartet, Pferd befindet sich auf Feld 3C, Springer angeklickt|Nichtaufleuchtendes Feld angeklickt|Pferd bleibt stehen, fehlermeldung "Dieser Spielzug ist nicht möglich".|
|03.12|Programm wurde gestartet, Dame befindet sich auf Feld 4G, Dame angeklickt|Aufleuchtendes Feld angeklickt|Dame verschwindet auf vorherigem Feld und ist auf dem neuen Feld.|
|03.13|Programm wurde gestartet|Dame angeklickt|Diese Fiegur kann nicht bewegt werden.|
|03.14|Programm wurde gestartet, Dame befindet sich auf Feld 4G, Dame angeklickt|Nichtaufleuchtendes Feld angeklickt|Dame bleibt stehen, fehlermeldung "Dieser Spielzug ist nicht möglich".|
|03.15|Programm wurde gestartet, König befindet sich auf Feld 2D, König angeklickt|Aufleuchtendes Feld angeklickt|König verschwindet auf vorherigem Feld und ist auf dem neuen Feld.|
|03.16|Programm wurde gestartet|König angeklickt|Diese Fiegur kann nicht bewegt werden.|
|03.17|Programm wurde gestartet, König befindet sich auf Feld 2D, König angeklickt|Nichtaufleuchtendes Feld angeklickt|König bleibt stehen, fehlermeldung "Dieser Spielzug ist nicht möglich".|
|04.||||
|05.||||
|06.||||
|07.1||||
|07.2||||
|08.1||||
|08.2||||
|09.1||||
|09.2||||
|10.1||||


✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

![Schach Diagramm](https://user-images.githubusercontent.com/110893245/203289894-11218cce-3de4-4aad-b521-826abbc6173b.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
|1.A|06.12.2022|Angelov|||
|1.B|06.12.2022|Angelov|||
|1.C|06.12.2022|Angelov|||
|2.A|06.12.2022|Herzig|||
|2.B|06.12.2022|Herzig|||
|2.C|06.12.2022|Herzig|||
|3.A|13.12.2022|Burlet|||
|3.B|13.12.2022|Burlet|||
|3.C|13.12.2022|Burlet|||
|4.A|06.12.2022|Eser|||
|4.B|06.12.2022|Eser|||
|4.C|06.12.2022|Eser|||
|5.A|06.12.2022|Veljkovic|||
|5.B|06.12.2022|Veljkovic|||
|5.C|06.12.2022|Veljkovic|||
|6.A|13.13.2022|Angelov|||
|6.B|13.13.2022|Angelov|||
|6.C|13.13.2022|Angelov|||
|7.A|13.12.2022|Herzig|||
|7.B|13.12.2022|Herzig|||
|7.C|13.12.2022|Herzig|||
|8.A|13.12.2022|Burlet|||
|8.B|13.12.2022|Burlet|||
|8.C|13.12.2022|Burlet|||
|9.A|06.12.2022|Veljkovic|||
|9.B|06.12.2022|Veljkovic|||
|9.C|06.12.2022|Veljkovic|||
|10.A|13.12.2022|Herzig|||
|10.B|13.12.2022|Herzig|||
|10.C|13.12.2022|Herzig|||



Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

Das Brett ist in einem 2D String Array.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
