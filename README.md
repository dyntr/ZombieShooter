# Game Design Document (GDD)

## Název: Zombie Shooter

### Autor: Patrick Dyntr
### Škola: SPŠE Ječná
### Předmět: MVH - Závěrečná práce

---

## 1. Úvod

**Zombie Shooter** je akční hra plná napětí, odehrávající se v městském prostředí, kde hráči musí přežít vlny zombíků. Hra je rozdělena do několika úrovní, přičemž každá další úroveň je náročnější díky vyššímu počtu a rychlejším pohybům zombíků. Tento dokument popisuje základní mechaniky, ovládání a funkce hry.

## 2. Přehled hry

### 2.1 Žánr
Akční, Střílečka, Survival

### 2.2 Platforma
PC

### 2.3 Cílová skupina
Teenageři a dospělí, kteří si užívají rychlé střílečky a výzvy v přežití.

### 2.4 Cíl hry
Hlavním cílem hráče je přežít v jednotlivých úrovních likvidací vln zombíků pomocí různých zbraní a efektivního spravování zdrojů.

---

## 3. Herní mechaniky

### 3.1 Ovládání
- **Pohyb:** 
  - `W` - Pohyb vpřed
  - `A` - Pohyb vlevo
  - `S` - Pohyb vzad
  - `D` - Pohyb vpravo
  - `Mezerník` - Skok

- **Svítilna:**
  - `F` - Zapnout/Vypnout svítilnu (výdrž 30 sekund, postupně se vybíjí)

- **Zbraň:**
  - **Míření a střelba:** 
    - Ovládání myší nebo touchpadem
    - Levé tlačítko pro střelbu

### 3.2 Zbraně a přebíjení
- Zbraň se používá k likvidaci zombíků.
- **Automatické přebíjení:**
  - Zbraň se automaticky přebíjí, když dojde munice.
  - Během přebíjení je krátká prodleva, během které hráč nemůže střílet.

### 3.3 Mechanika svítilny
- Svítilna je klíčová pro viditelnost v tmavých oblastech.
- Má omezenou životnost baterie 30 sekund.
- Baterie se postupně vybíjí, což vyžaduje strategické využívání.

### 3.4 Postup úrovněmi
- Hra je strukturována do úrovní.
- Jak hráč postupuje, počet zombíků se zvyšuje a jejich rychlost a agresivita narůstá.

---

## 4. Návrh úrovní

### 4.1 Prostředí
- Hra se odehrává v městském bloku, obsahujícím městské prvky jako budovy, ulice a uličky.
- Každá úroveň představuje nové části města, což činí průzkum nezbytným pro přežití.

### 4.2 Zombíci
- Zombíci se objevují v rostoucím počtu, jak hráč postupuje úrovněmi.
- Projevují různé rychlosti a vzory útoků, což vyžaduje, aby hráči neustále přizpůsobovali své strategie.

---

## 5. Grafický a zvukový design

### 5.1 Vizuální styl
- Realistické, tmavé a drsné městské prostředí.
- Detailní modely postav a zombíků s animacemi.

### 5.2 Zvukové efekty a hudba
- Pohlcující zvukové efekty pro střelbu, přebíjení a pohyby zombíků.
- Napínavá hudba na pozadí, která zvyšuje atmosféru a intenzitu hry.

---

## 6. Technické specifikace

### 6.1 Herní engine
- Hra byla vyvinuta pomocí Unity 2022.3.5F1, což podporuje požadovanou grafiku a mechaniky.

### 6.2 Výkon
- Hra byla optimalizována pro plynulý výkon na středně výkonných počítačích.

### 6.3 Uživatelské rozhraní
- Intuitivní a minimalistické uživatelské rozhraní pro snadnou navigaci a ovládání.

---

## 7. Závěr

**Zombie Shooter** má za cíl poskytnout poutavý a náročný zážitek pro hráče, kteří si užívají akční střílečky a výzvy v přežití. Díky dynamické hratelnosti, strategickému spravování zdrojů a stupňující se obtížnosti hra slibuje, že hráče udrží na kraji sedadla.

---

## 8. Příloha

### 8.1 Reference
- Herní mechaniky a ovládací schémata inspirována populárními akčními survival hrami.
- Vizualizace a zvukový design vycházejí z her s městskou tématikou.

---

**Patrick Dyntr**

*SPŠE Ječná*

*Závěrečná práce z předmětu MVH*

---

## 9. Aktuální stav hry

Hra je již hotová a byla vytvořena v Unity 2022.3.5F1 na Macu. Je potřeba vytvořit build pro distribuci. Ve hře je zahrnut zvuk pozadí a zvuk střelby.
