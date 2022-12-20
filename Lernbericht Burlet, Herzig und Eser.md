# Lern-Bericht

Eser, Herzig und Burlet

## Einleitung

In diesem Projekt geht es darum, mit Windows Forms ein Schachspiel zu programmieren.

## Was habe ich gelernt?

Wir haben gelernt, wie man einen Text, von einem Button zum anderen, verschieben kann.

## Beschreibung

```csharp


        private void button1_Click(object sender, EventArgs e)
        {
            //Defines position of field
            int x = 1;
            int y = 1;
            if (temp != "")
            {
                if (test[x, y] == true)
                {
                    //Saves the name of the field into the temp
                    button1.Text = temp;
                    temp = "";
                    Reset();
                }
                
            }
            else
            {
                Check(x, y);
                //Fills in the name of the temp variable, if something is in it.
                temp = button1.Text;
                button1.Text = "";
            }
        }
            
```
In diesem Abschnitt sieht man unter den Kommentaren die einfache Funktion, wie das funktioniert.
Dabei speichert es den Namen des Feldes, wenn temp leer ist und wenn temp einen Inhalt hat, wird der Text von Button 1 verändert zu dem Wert von Temp.



https://user-images.githubusercontent.com/110892985/208626809-44630331-f47e-4607-a98d-1619811b575a.mp4

Im Video ist zu sehen, dass wenn man auf einen befüllten Button klickt, dass dann der Text verschwindet. 
Wenn man dann auf ein anderes Feld klickt, wird dieses befüllt mit dem Text vom alten Feld.


Technische allgemeine Beschreibung:

Es wird geprüft, ob die Variable temp nicht nichts beinhaltet, 
wenn das nicht der Fall ist, wird der Name des Feldes in die temp variable kopiert und der Text vom angeklickten Feld verschwindet.
Klickt man danach auf ein anderes Feld überprüft es nochmals, ob die Variable temp nicht nichts beinhaltet, jedoch hat diese nun einen Wert.
Jetzt wird der Text des Feldes mit dem Text von temp ersetzt und temp wird wieder zu "" gemacht.

## Verifikation

1: Man sieht, wie der Austausch im Code funktioniert.
2: Im Video sieht man, wie dieser (der Austausch) in der Praxis aussieht.
3: Die Beschreibung erklärt, wie das technisch funktioniert.

# Reflexion zum Arbeitsprozess
Das lief gut:
Am Ende konnten wir relativ schnell, dieses Produkt erstellen.

Das lief nicht so gut:
Die Zusammenarbeit lief gar nicht gut, die Aufteilung war nicht klar und niemand wusste so recht, was er/sie machen sollte.

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.
****
Beim nächsten Mal sollte man als Gruppenleiter nochmals nachfragen, ob alles klar ist und ob man versteht, was man machen muss.
Als Gruppenmitglied sollte man den Gruppenleiter, bei Unklarheiten, allenfalls fragen, ob man das, was man aufgetragen bekommen hat, richtig verstanden hat.

