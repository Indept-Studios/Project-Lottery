
### **Game Design Document (GDD)**

----------

**1. Titel des Spiels:**

-   **Lotto-Verk�ufer Tycoon**

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

-   Der Spieler �bernimmt die Rolle eines **Losverk�ufers**, der zwei Arten von Losen verkauft: Rubellose und 6-aus-49-Lose. Ziel ist es, durch geschicktes Preismanagement und das Anziehen von Kunden m�glichst hohe Gewinne zu erzielen und das eigene Gesch�ft zu erweitern.

----------

### **6. Spielidee und Setting**

Der Spieler schl�pft in die Rolle eines kleinen Losverk�ufers, der t�glich **Rubellose** und **6-aus-49-Lose** an seine Kunden verkauft. Der Spieler agiert dabei als Unternehmer und kann die Preise der Lose selbst festlegen, wodurch er direkten Einfluss auf die Anzahl der Kunden und seine Gewinne hat.

Es gibt zwei Hauptspielmechaniken:

#### **6.1. Rubellose**:

-   Der Spieler kauft t�glich eine festgelegte Anzahl von Rubellosen ein.
-   Diese Lose werden an die Kunden verkauft.
-   Kunden erhalten direkt R�ckmeldung, ob sie gewonnen haben. Gewinne werden sofort ausgezahlt.
-   Die Wahrscheinlichkeit eines Gewinns ist vorab definiert und zufallsbasiert.

#### **6.2. 6-aus-49 Lotto (Lotto)**:

-   Kunden kaufen ein Los und w�hlen 6 Zahlen.
-   Jeden Abend nach Verkaufsschluss werden 6 Gewinnzahlen per Tombola (Zufallsmechanismus) ermittelt.
-   Gewinne basieren auf der Anzahl der �bereinstimmenden Zahlen, und die H�he der Gewinne richtet sich nach den Einnahmen des Tages (prozentualer Anteil der Verkaufserl�se).

----------

### **7. Wirtschaftssystem und Preisgestaltung**

-   Der Spieler kann den **Preis der Lose** (Rubellose und Lotto-Lose) individuell festlegen. Ein h�herer Preis f�r den Kunden bedeutet mehr Gewinn f�r den Spieler, aber es gibt weniger Teilnehmer.
-   Ein dynamisches **Kundenverhalten** sorgt daf�r, dass Kunden empfindlich auf Preis�nderungen reagieren. Je h�her der Preis, desto weniger Lose werden verkauft. Das Spiel wird also durch die richtige Balance zwischen Preis und Kundennachfrage herausfordernd.
-   Der Gewinn wird �ber die t�gliche Bilanz berechnet: **Einnahmen** (verkaufte Lose) - **Ausgaben** (eingekaufte Lose, ausgezahlte Gewinne) = Tagesgewinn.
-   Je l�nger das Spiel dauert, desto schwerer wird es, eine hohe Marge zu halten (die Gewinnmarge sinkt langfristig).

----------

### **8. Spielerfortschritt und Highscores**

-   Der **Spielstand** wird gespeichert (z.B. als JSON-Datei), in der alle wichtigen Informationen wie **Einnahmen, Ausgaben, verkaufte Lose, Gewinne und Bekanntheitsgrad** des Unternehmens gespeichert werden.
-   Das Spiel simuliert ein **Jahr**, wobei jeder Tag 2 Minuten Echtzeit dauert und es pro Woche 5 Arbeitstage gibt.
-   Nach Abschluss eines Spieljahres wird der Fortschritt des Spielers mit dem vorherigen Spiel verglichen. Dieser Vergleich basiert auf **Kennzahlen** wie:
    -   Gesamtgewinn
    -   Anzahl verkaufter Lose
    -   Anzahl der Teilnehmer (Kunden)
    -   H�he des Jackpots und die Anzahl der gewonnenen Jackpots durch Kunden.

----------

### **9. Balancing der Spielfortschritte**

-   **Preise und Kundennachfrage**: Je h�her der Preis, desto weniger Lose werden verkauft. Der Spieler muss den richtigen Preis finden, um gen�gend Kunden zu halten und dennoch Gewinne zu maximieren.
-   **Sinkende Marge**: Die Gewinnmargen sinken mit der Zeit, sodass der Spieler immer wieder seine Strategien anpassen muss, um im Gesch�ft zu bleiben.
-   **Bekanntheitsgrad**: Der Erfolg des Losverk�ufers steigt mit der Bekanntheit. Wenn der Verk�ufer viele Lose verkauft oder ein gro�er Jackpot ansteht, steigt die Bekanntheit, was zu mehr Kunden f�hrt.

----------

### **10. Schwierigkeit und Herausforderung**

-   **Spielzeit**: Ein Jahr Simulation, wobei pro Woche 5 Tage gespielt wird, und jeder Tag dauert 2 Minuten.
-   **Spielziele**: Am Ende des Jahres wird der Spieler anhand von Erfolgskennzahlen bewertet (z.B. Gewinne, verkaufte Lose, verlorene Kunden). J�hrliche Ziele k�nnten gesetzt werden, wie z.B. einen Mindestgewinn oder eine bestimmte Kundenzahl zu erreichen.

----------

### **11. Feedback und Zufriedenheitssystem der Kunden**

-   Das Verhalten der Kunden basiert auf der **Bekanntheit** des Verk�ufers und der **Gr��e des Jackpots**. H�here Bekanntheit oder ein gro�er Jackpot ziehen mehr Kunden an.
-   Es gibt kein komplexes Zufriedenheitssystem, aber die Kunden reagieren auf hohe Preise und eine unattraktive Gewinnchance durch weniger K�ufe.

----------

### **12. Visuelles und Auditives Feedback**

-   Eine **Eventanzeige** am unteren Bildschirmrand zeigt die letzten drei Ereignisse an, wie z.B.:
    -   "10 Rubellose verkauft, 1 Gewinner, 100� ausgezahlt."
    -   "50 Lotto-Lose verkauft, Jackpot steht bei 1.000�."
    -   "Einbruch! 500� wurden gestohlen."
    -   "Die Gl�cksspielkommission hat 200� Strafe verh�ngt."
-   Diese Events geben dem Spieler direktes Feedback zu seiner Tagesperformance.

----------

### **13. Systeme und Mechaniken**

-   **Rubellos-Mechanik**: Die Kunden kaufen Rubellose und erfahren sofort, ob sie gewonnen haben. Gewinne werden direkt ausgezahlt. Die Gewinnwahrscheinlichkeit ist zufallsbasiert.
-   **Lotto-Mechanik**: Jeden Abend werden 6 Zahlen gezogen. Gewinne h�ngen davon ab, wie viele der gew�hlten Zahlen mit den gezogenen Zahlen �bereinstimmen. Der Gewinn h�ngt vom Umsatz des Tages ab.
-   **Ereignisse und Zufallsfaktoren**: Bestimmte Ereignisse (z.B. �berf�lle, Strafen durch die Gl�cksspielkommission, Krankheit des Verk�ufers) k�nnen den Verlauf des Tages beeinflussen.

----------

### **14. Speichermechanismus**

-   Spielst�nde und Statistiken werden in einer **JSON-Datei** gespeichert. Die Datei enth�lt Daten wie **Einnahmen, Ausgaben, Anzahl der verkauften Lose, Gewinne, und Bekanntheitsgrad** des Unternehmens.

----------

### **15. Erweiterungsm�glichkeiten**

-   Weitere **Losarten** und **Lotteriespiele** k�nnten hinzugef�gt werden.
-   Es k�nnten unterschiedliche **Kundengruppen** eingef�hrt werden, die verschiedene Kaufverhalten zeigen.
-   Dynamischere **Preisgestaltung** und **Marktschwankungen** k�nnten integriert werden, um das Spiel realistischer und herausfordernder zu gestalten.