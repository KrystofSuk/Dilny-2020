# Pondeli (Unity, Playground)
75 15 33 C0 EB 13 90
## Unity

Multiplatformni herni engine, pro tvorbu 2D a 3D her. Zakladnim stavebnim kamenem jsou **GameObjecty**. To jsou kontejnery s nejakym nazvem, mohou byt ruzne zanorene a spolecne tvori **Scenu**. GameObjecty maji **Componenty** coz jsou jednotlive skripty / vlastnosti daneho objektu. Napriklad fyzika, pohyb na sipky atd... 

![alt text](https://www.rivellomultimediaconsulting.com/wp-content/uploads/2013/05/unity14_diagram-500x243.png "Structure")

---

### Window

Jednotliva okna, ktera umoznuji modifikovani a vytvareni hry. 

#### Project

Zdrojove soubory projektu, napr: modely, textury, audio, sceny atp... Soubory zde jdou nalezt primo na disku pocitace ve slozce NazevProjektu/Assets.
![alt text](src/project.png "Structure")

#### Hierarchy

Jednotlive GameObjecty ve scene. Pokud chceme pridat / odebrat GameObject tak to musim provest zde.
![alt text](src/hierarchy.png "Structure")

#### Inspector

Zobrazi detailni informace, pro upravu vybraneho souboru / GameObjectu.
![alt text](src/inspector.png "Structure")

##### GameObject

Detail vybraneho GameObjectu, zde jsou k nahlednuti a modifikaci jednotlive **Componenty** GameObjectu. Muzeme je pridat pomoci tlacitka Add Component / odebrat pomoci tri tecek nebo praveho clicku.

##### Soubor

Detail vybraneho souboru, napr textury. Pro kazdy soubor jsou jine moznosti.

#### Scene

Manipulacni okno s GameObjecty, zde vidime kde jsou umistene, natocene, jejich rotaci a muzeme tyto parametry upravovat. Jednotlive mody, muzeme menit v levem hornim rohu. Zleva: nic / pohyb / rotace / velikost / 2D velikost / multi ruzice (pohyb rotace scale) / custom.

![alt text](src/manip.png "Structure")

#### Game

Pohled kamery, zde je presne reprezentovano, co hrac uvidi skrz kameru.

#### Asset Store

Obchod s assety a pluginy do unity, obsahuje spoustu free veci, ktere si muzete stahnout. Cokoli stazene pres store, se umisti do Project window a na disk.

---

### Playground

Plugin / balicek **Component** a grafiky. Obsahuje zjednodusene componenty, pro tvorbu jednoduchych 2D her. Pondeli a Utery budeme travit s timto pluginem. Rozhodne nemazte zadnou slozku, vytvorenou timto balickem. Balicek bud budete mit primo v projektu, jiz od nas / budete jej moct stahnout v Asset Storu po vyhledani Playground.

Componenty z Playgroundu se daji pridat pomoci

![alt text](src/component.png "Structure")

Jednotlive componenty jsou vysvetlene ve slozce Documentation a souboru Cheatsheet.

![alt text](src/1%20-%20Movement.jpg "Structure")
![alt text](src/2%20-%20Movement2.jpg "Structure")
![alt text](src/3%20-%20Gameplay.jpg "Structure")
![alt text](src/4%20-%20Attributes.jpg "Structure")
![alt text](src/5%20-%20Conditions.jpg "Structure")
![alt text](src/6%20-%20Actions.jpg "Structure")