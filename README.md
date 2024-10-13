
### **Game Design Document (GDD)**

----------

**1. Titel des Spiels:**

-   **Lotto-Verkäufer Tycoon**

----------

**2. Genre:**

-   **Simulation**, **Wirtschaft**

----------

**3. Zielgruppe:**

-   Spieler, die gerne Management- und Simulationsspiele spielen.

----------

**4. Plattform:**

-   **Desktop** (Windows, Winforms)

----------

**5. Spielbeschreibung:**

-   Der Spieler übernimmt die Rolle eines **Losverkäufers**, der zwei Arten von Losen verkauft: Rubellose und 6-aus-49-Lose. Ziel ist es, durch geschicktes Preismanagement und das Anziehen von Kunden möglichst hohe Gewinne zu erzielen und das eigene Geschäft zu erweitern.

----------

### **6. Spielidee und Setting**

Der Spieler schlüpft in die Rolle eines kleinen Losverkäufers, der täglich **Rubellose** und **6-aus-49-Lose** an seine Kunden verkauft. Der Spieler agiert dabei als Unternehmer und kann die Preise der Lose selbst festlegen, wodurch er direkten Einfluss auf die Anzahl der Kunden und seine Gewinne hat.

Es gibt zwei Hauptspielmechaniken:

#### **6.1. Rubellose**:

-   Der Spieler kauft täglich eine festgelegte Anzahl von Rubellosen ein.
-   Diese Lose werden an die Kunden verkauft.
-   Kunden erhalten direkt Rückmeldung, ob sie gewonnen haben. Gewinne werden sofort ausgezahlt.
-   Die Wahrscheinlichkeit eines Gewinns ist vorab definiert und zufallsbasiert.

#### **6.2. 6-aus-49 Lotto (Lotto)**:

-   Kunden kaufen ein Los und wählen 6 Zahlen.
-   Jeden Abend nach Verkaufsschluss werden 6 Gewinnzahlen per Tombola (Zufallsmechanismus) ermittelt.
-   Gewinne basieren auf der Anzahl der übereinstimmenden Zahlen, und die Höhe der Gewinne richtet sich nach den Einnahmen des Tages (prozentualer Anteil der Verkaufserlöse).

----------

### **7. Wirtschaftssystem und Preisgestaltung**

-   Der Spieler kann den **Preis der Lose** (Rubellose und Lotto-Lose) individuell festlegen. Ein höherer Preis für den Kunden bedeutet mehr Gewinn für den Spieler, aber es gibt weniger Teilnehmer.
-   Ein dynamisches **Kundenverhalten** sorgt dafür, dass Kunden empfindlich auf Preisänderungen reagieren. Je höher der Preis, desto weniger Lose werden verkauft. Das Spiel wird also durch die richtige Balance zwischen Preis und Kundennachfrage herausfordernd.
-   Der Gewinn wird über die tägliche Bilanz berechnet: **Einnahmen** (verkaufte Lose) - **Ausgaben** (eingekaufte Lose, ausgezahlte Gewinne) = Tagesgewinn.
-   Je länger das Spiel dauert, desto schwerer wird es, eine hohe Marge zu halten (die Gewinnmarge sinkt langfristig).

----------

### **8. Spielerfortschritt und Highscores**

-   Der **Spielstand** wird gespeichert (z.B. als JSON-Datei), in der alle wichtigen Informationen wie **Einnahmen, Ausgaben, verkaufte Lose, Gewinne und Bekanntheitsgrad** des Unternehmens gespeichert werden.
-   Das Spiel simuliert ein **Jahr**, wobei jeder Tag 2 Minuten Echtzeit dauert und es pro Woche 5 Arbeitstage gibt.
-   Nach Abschluss eines Spieljahres wird der Fortschritt des Spielers mit dem vorherigen Spiel verglichen. Dieser Vergleich basiert auf **Kennzahlen** wie:
    -   Gesamtgewinn
    -   Anzahl verkaufter Lose
    -   Anzahl der Teilnehmer (Kunden)
    -   Höhe des Jackpots und die Anzahl der gewonnenen Jackpots durch Kunden.

----------

### **9. Balancing der Spielfortschritte**

-   **Preise und Kundennachfrage**: Je höher der Preis, desto weniger Lose werden verkauft. Der Spieler muss den richtigen Preis finden, um genügend Kunden zu halten und dennoch Gewinne zu maximieren.
-   **Sinkende Marge**: Die Gewinnmargen sinken mit der Zeit, sodass der Spieler immer wieder seine Strategien anpassen muss, um im Geschäft zu bleiben.
-   **Bekanntheitsgrad**: Der Erfolg des Losverkäufers steigt mit der Bekanntheit. Wenn der Verkäufer viele Lose verkauft oder ein großer Jackpot ansteht, steigt die Bekanntheit, was zu mehr Kunden führt.

----------

### **10. Schwierigkeit und Herausforderung**

-   **Spielzeit**: Ein Jahr Simulation, wobei pro Woche 5 Tage gespielt wird, und jeder Tag dauert 2 Minuten.
-   **Spielziele**: Am Ende des Jahres wird der Spieler anhand von Erfolgskennzahlen bewertet (z.B. Gewinne, verkaufte Lose, verlorene Kunden). Jährliche Ziele könnten gesetzt werden, wie z.B. einen Mindestgewinn oder eine bestimmte Kundenzahl zu erreichen.

----------

### **11. Feedback und Zufriedenheitssystem der Kunden**

-   Das Verhalten der Kunden basiert auf der **Bekanntheit** des Verkäufers und der **Größe des Jackpots**. Höhere Bekanntheit oder ein großer Jackpot ziehen mehr Kunden an.
-   Es gibt kein komplexes Zufriedenheitssystem, aber die Kunden reagieren auf hohe Preise und eine unattraktive Gewinnchance durch weniger Käufe.

----------

### **12. Visuelles und Auditives Feedback**

-   Eine **Eventanzeige** am unteren Bildschirmrand zeigt die letzten drei Ereignisse an, wie z.B.:
    -   "10 Rubellose verkauft, 1 Gewinner, 100€ ausgezahlt."
    -   "50 Lotto-Lose verkauft, Jackpot steht bei 1.000€."
    -   "Einbruch! 500€ wurden gestohlen."
    -   "Die Glücksspielkommission hat 200€ Strafe verhängt."
-   Diese Events geben dem Spieler direktes Feedback zu seiner Tagesperformance.

----------

### **13. Systeme und Mechaniken**

-   **Rubellos-Mechanik**: Die Kunden kaufen Rubellose und erfahren sofort, ob sie gewonnen haben. Gewinne werden direkt ausgezahlt. Die Gewinnwahrscheinlichkeit ist zufallsbasiert.
-   **Lotto-Mechanik**: Jeden Abend werden 6 Zahlen gezogen. Gewinne hängen davon ab, wie viele der gewählten Zahlen mit den gezogenen Zahlen übereinstimmen. Der Gewinn hängt vom Umsatz des Tages ab.
-   **Ereignisse und Zufallsfaktoren**: Bestimmte Ereignisse (z.B. Überfälle, Strafen durch die Glücksspielkommission, Krankheit des Verkäufers) können den Verlauf des Tages beeinflussen.

----------

### **14. Speichermechanismus**

-   Spielstände und Statistiken werden in einer **JSON-Datei** gespeichert. Die Datei enthält Daten wie **Einnahmen, Ausgaben, Anzahl der verkauften Lose, Gewinne, und Bekanntheitsgrad** des Unternehmens.

----------

### **15. Erweiterungsmöglichkeiten**

-   Weitere **Losarten** und **Lotteriespiele** könnten hinzugefügt werden.
-   Es könnten unterschiedliche **Kundengruppen** eingeführt werden, die verschiedene Kaufverhalten zeigen.
-   Dynamischere **Preisgestaltung** und **Marktschwankungen** könnten integriert werden, um das Spiel realistischer und herausfordernder zu gestalten.