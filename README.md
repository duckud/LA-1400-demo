# LA-1400-demo

# Hütchenspiel

## Aufgabenstellung und Ziele

Im Lernatelier durften wir in der Gruppe zusammen ein Spiel programmieren, indem wir WinForms gebrauchten. Es ist ein Hütchenspiel, in dem man Geld auf ein Hütchen wetten kann, und wenn unter dem Hütchen ein "Coin" ist, erhält man dafür Punkte. Für dieses Spiel braucht es 3 Hütchen, die sich bewegen, wenn man darauf klickt. Ich werde Ihnen also erklären, wie man Bilder im Gesamten zum Bewegen bringen kann, wenn man darauf klickt.

**Ziele**:
1. Der Leser versteht, wie man Bilder mit einem Klick zum Bewegen bringt.
## Inhalt 1

Im Spiel, das wir programmierten braucht es, wie schon gesagt, Hütchen, die sich bewegen, wenn man auf sie klickt. Diese Funktion mussten wir einbauen, damit der User sehen kann, ob sie die Runde gewonnen, also die Hütchen richtig erraten haben, oder nicht. Zuerst fügt man ein Bild mit einer PictureBox hinzu. Sagen wir mal dies ist die PictureBox Nummer 1. Wenn man doppelt darauf klickt wird der Code mit einer neuen Funktion namens "pictureBox1_Click" geöffnet. Das heisst, wenn man auf das Bild klickt wird der Code in dieser Funktion ausgeführt, hier hineinkommt also unser Code. Um das Bild zu bewegen, erteilt man dem Bild eine neue Position, und für das braucht man die x-/ und y-Achse. Also sagt man sozusagen, dass das Bild sich auf den neuen Ort verschiebt, die man mit der x-/ und y-Achse bestimmt, wenn man darauf klickt. Den spezifischen Code werde ich beim "Inhalt 2"aufschreiben.

## Inhalt 2
Hier ist ein Code-Beispiel, wie wir es in unserem Programm ausgeübt haben:
```csharp
//die Funktion
private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1_Click.Location = new Point(20, 50);
            //einteilung zum neuen Ort, 20 ist die x und 50 die y-Achse
        }
```

## Inhalt 3

Hier zeige ich, wie die Bewegung des Bildes aussieht:
[YouTube Video](https://www.youtube.com/watch?v=5d73FI0AEi4)

## Verifikation + Reflexion 

**Reflexion**:
Während der Gruppenarbeit habe ich viel alleine gearbeitet, obwohl man in der Gruppe arbeiten musste. Die Kommunikation in der Gruppe funktionierte auch nicht so und daher wusste ich fast nie, wie weit wir als Gruppe sind.

VBV: Das nächste Mal werde ich meine Gruppenmitglieder ansprechen und mit ihnen zusammen arbeiten.

**Verifikation**:
Ziel 1: Ich habe dieses Portfolio meinem Pultnachbar gezeigt, *Ziel erreicht*
