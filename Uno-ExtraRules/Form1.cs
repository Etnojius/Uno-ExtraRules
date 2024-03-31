using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uno_ExtraRules
{
    public partial class Form1 : Form
    {
        public List<string> rules = new List<string>
        {
            "Dra 10 kort.",
            "Nästa gång du får Uno måste du meddela vilken färg och valör ditt sista kort har. Räknas även om du får uno av det här kortet.",
            "Ta 1 slumpmässigt kort ur varje spelares hand, om det inte är deras sista kort.",
            "Du får inte säga något tills nästa gång det blir din tur. Om du gör det drar du 10 kort.",
            "Det blir spelaren med mest korts tur. Kan bli dig själv igen.",
            "Du kan inte längre vinna genom att få slut kort. Du vinner istället när spelaren till höger får slut kort.",
            "Meddela en färg. Alla andra spelare ger dig alla kort de har av den färgen, förutom 1 om de skulle vinna på det.",
            "Dos måste nu sägas varje gång man har 2 kort kvar, med samma regler som Uno.",
            "Slumpa fram en effekt. Aktivera den eller dra 2 kort.",
            "Dra 5 kort ur drahögen, behåll 2 av dem.",
            "Alla kvarvarande effekter som finns just nu försvinner.",
            "Alla spelare drar lika många kort som de har på handen. Max 10 kort.",
            "Alla spelare drar 1 kort.",
            "Alla spelare ger sin hand till spelaren till höger.",
            "Välj ett ord. Varje gång någon säger det ordet måste den personen dra 2 kort. Uno kan inte väljas.",
            "Släng valfri mängd kort ur din hand. Dra lika många kort som du slängde.",
            "Nästa spelare som får slut kort måste dra 10 kort, spelet fortsätter sedan som vanligt.",
            "Alla slänger alla sina kort och drar lika många som de hade, högst 10 kort.",
            "Nästa gång en annan spelare får dig att på något sätt få fler kort, ge de korten till en valfri spelare.",
            "Alla spelare spelar med öppen hand tills det blir din tur igen.",
            "Slumpa fram 1 effekt. Aktivera den eller så drar alla andra spelare varsitt kort.",
            "Alla spelare drar eller slänger (slumpmässigt) kort tills de har 10 - det antal kort de tidigare hade. Minst 2 kort behålls.",
            "Meddela den färg som du tror det finns flest av i de 20 översta korten i slänghögen. Har du rätt, drar alla andra spelare 2 slumpmässiga kort från din hand var. Har du fel, så får du istället dra 1 slumpmässigt kort från varje spelares hand.",
            "Titta på valfri spelares hand.",
            "Slumpa fram 4 olika effekter och välj en av dem att aktivera",
            "Om du vill det försvinner alla kvarvarande effekter som finns just nu.",
            "Förutom dig själv, skippa alla spelare som har en udda mängd korts nästa tur.",
            "Alla spelare som har tagit sig ur spelet drar 3 kort och fortsätter spela.",
            "Dra 5 kort och spela dem alla i valfri ordning. Alla effekter aktiveras.",
            "Dra 2 kort för varje annan spelare, dela sedan ut dem mellan alla spelare på valfritt sätt.",
            "Det blir din tur igen. Funkar inte om du bara har 1 kort kvar.",
            "Slumpa fram 3 olika effekter och välj 1 av dem att aktivera.",
            "Bygg ett korthus med kort ur drahögen. När tornet rasar delas korten ut mellan alla andra spelare. Byggandet får pågå i max en minut.",
            "Alla spelare måste ge dig alla sina specialkort. (Allt som inte är ett sifferkort)",
            "Välj en spelare. Den spelaren väljer 2 fiktionella karaktärer. Gissa vilken som skulle vinna i en strid. Fråga en valfri AI-tjänst. Om du har rätt ger du den andra spelaren 5 av dina kort, du väljer vilka. Tvärtom om du gissar fel. Om AI-tjänsten inte vill ge ett svar slumpa en vinnare.",
            "Alla andra spelare drar 10 kort.",
            "Släng alla kort i din hand av ev viss färg. Färgen bestäms av det högsta färgkortet i slänghögen.",
            "Nästa spelare (förutom dig själv) som drar kort drar istället från din hand.",
            "Släng slumpmässigt hälften av dina kort, avrundat nedåt.",
            "Multifärgade kort kan inte spelas tills det blir din tur igen.",
            "Titta på de 10 översta korten i draghögen och placera dem i valfri ordning.",
            "Slänghögen läggs ovanpå drahögen, med framsidan uppåt.",
            "Tills det blir din tur igen räknas det översta kortet i slänghögen som ett färgkort där du väljer färgen.",
            "Välj en spelare. Den spelaren väljer 2 fiktionella karaktärer. Gissa vilken som skulle vinna i en schackmatch. Fråga en valfri AI-tjänst. Om du har rätt ger du den andra spelaren 5 av dina kort, du väljer vilka. Tvärtom om du gissar fel. Om AI-tjänsten inte vill ge ett svar slumpa en vinnare.",
            "Slumpa fram en effekt. Tills det blir din tur igen blir det alltid den effekten när en effekt ska slumpas. Effekten aktiveras även för dig själv.",
            "Ta bort valfri kvarvarande effekt.",
            "Alla börjar nu sina rundor med att dra ett kort.",
            "När du får slut kort nästa gång så drar du istället 3 kort och flyttar den här effekten till valfri spelare.",
            "Alla måste säga \"t\" innan varje färg. Misslyckas man med det så måste man dra 2 kort.",
            "Välj en spelare. Den spelaren väljer 2 djur. Gissa vilket som skulle vinna i en strid. Fråga en valfri AI-tjänst. Om du har rätt ger du den andra spelaren 5 av dina kort, du väljer vilka. Tvärtom om du gissar fel. Om AI-tjänsten inte vill ge ett svar slumpa en vinnare.",
            "Tills det blir din tur igen måste alla kort spelas på ett dramatiskt sätt. Alla som inte är tillräckligt dramatiska måste dra 2 kort.",
            "Färgkort måste nu istället spelas på inverterad färg, alltså rött på grönt, grönt på rött, gult på blått och blått på gult.",
            "Nästa effekt som aktiveras aktiveras 2 gånger.",
            "Lägg 10 kort ur draghögen åt sidan med framsidan uppåt. När kort ska dras från draghögen dras istället ett valfritt kort härifrån.",
            "Välj en färg. Färgkort av den färgen får inte spelas tills det blir din tur igen.",
            "Du får en gång tvinga en annan spelare att slå om när en effekt ska slumpas fram. Funkar inte när en effekt gör att andra effekter ska slumpas fram.",
            "Du får en gång välja att spela ett tomt färgvalskort när en annan spelare spelat sitt sista kort. Den spelaren måste då ta tillbaka det kortet och det blir nästa spelares tur, men färgvalskortet har ingen annan effekt.",
            "Slumpa fram 4 olika effekter och välj en av dem att aktivera.",
            "Välj en färg och en spelare. Den spelaren får dra kort ur draghögen tills hen får ett kort av den valda färgen.",
            "Välj en spelare som missar sin nästa tur.",
            "Dra kort och släng dem tills du drar ett sifferkort. Om det är rött eller gult så drar alla andra den mängd som står på kortet, annars gör du det.",
            "Alla kvarvarande effekter som finns just nu försvinner.",
            "Alla spelare slänger 2 valfria kort, men måste ha kvar minst 2.",
            "Två personer, förutom dig själv, som du väljer måste byta hand med varann.",
            "Alla ger 3 valfria kort till personen till höger.",
            "Välj en spelare. Den spelaren måste slänga alla sina flerfärgade kort och dra lika många nya.",
            "Välj en spelare. Ge den spelaren ett påstående. Den spelaren måste gissa om påståendet är sant eller falskt. Om spelaren har rätt måste du dra 3 kort från hen. Annars blir det tvärtom.",
            "Slumpa fram 2 effekter, välj en av dem att aktivera.",
            "Slumpa fram 2 effekter, välj en av dem att aktivera.",
            "Slumpa fram 2 effekter, välj en av dem att aktivera.",
            "Slumpa fram 2 effekter, välj en av dem att aktivera.",
            "Slumpa fram 2 effekter, välj en av dem att aktivera.",
            "Spelare får nu som mest ha 10 kort på handen. Om den mängden överstigs måste den spelare slänga kort tills hen återigen har 10 kort"

        };

        public string[] currentRules = new string[11];
        public Random random = new Random();
        
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < currentRules.Length; i++) 
            {
                currentRules[i] = string.Empty;
            }
        }

        public void UpdateText()
        {
            textBox1.Text = currentRules[0];
            button1.Text = currentRules[1];
            button2.Text = currentRules[2];
            button3.Text = currentRules[3];
            button4.Text = currentRules[4];
            button5.Text = currentRules[5];
            button6.Text = currentRules[6];
            button7.Text = currentRules[7];
            button8.Text = currentRules[8];
            button9.Text = currentRules[9];
            button10.Text = currentRules[10];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentRules[0] = currentRules[1];
            ClearAndUpdate();
        }

        public void ClearAndUpdate()
        {
            for (int i = 1; i < 5; i++)
            {
                currentRules[i] = string.Empty;
            }
            UpdateText();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) 
            {
                int i = 0;
                while (i < 5) 
                {
                    if (currentRules[i] == string.Empty) 
                    {
                        string temp = rules[random.Next(rules.Count)];
                        while (currentRules.Contains(temp))
                        {
                            temp = rules[random.Next(rules.Count)];
                        }
                        currentRules[i] = temp;
                        i = 10;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            else if (e.KeyCode == Keys.D1)
            {
                AddNewLastingEffect(0);
            }
            else if (e.KeyCode == Keys.D2)
            {
                AddNewLastingEffect(1);
            }
            else if (e.KeyCode == Keys.D3)
            {
                AddNewLastingEffect(2);
            }
            else if (e.KeyCode == Keys.D4)
            {
                AddNewLastingEffect(3);
            }
            else if (e.KeyCode == Keys.D5)
            {
                AddNewLastingEffect(4);
            }
            else if (e.KeyCode == Keys.C)
            {
                for (int i = 0; i < 5; i++)
                {
                    currentRules[i] = string.Empty;
                }
            }
            else if (e.KeyCode == Keys.D0)
            {
                textBox2.Visible = true;
                textBox2.Enabled = true;
                textBox2.Text = string.Empty;
                button11.Visible = true;
                button11.Enabled = true;
            }
            UpdateText();

        }

        private void AddNewLastingEffect(int number)
        {
            int i = 5;
            while (i < 11)
            {
                if (currentRules[i] == string.Empty)
                {
                    currentRules[i] = currentRules[number];
                    i = 15;
                }
                else
                {
                    i++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentRules[0] = currentRules[2];
            ClearAndUpdate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentRules[0] = currentRules[3];
            ClearAndUpdate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentRules[0] = currentRules[4];
            ClearAndUpdate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentRules[5] = string.Empty;
            UpdateText();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentRules[6] = string.Empty;
            UpdateText();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentRules[7] = string.Empty;
            UpdateText();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentRules[8] = string.Empty;
            UpdateText();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentRules[9] = string.Empty;
            UpdateText();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            currentRules[10] = string.Empty;
            UpdateText();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty)
            {
                rules.Add(textBox2.Text);
            }
            textBox2.Visible = false;
            textBox2.Enabled = false;
            button11.Visible = false;
            button11.Enabled = false;
        }
    }
}
