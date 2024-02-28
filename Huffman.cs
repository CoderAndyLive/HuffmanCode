using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuffmanCode
{
    public partial class Huffman : Form
    {
        public Huffman()
        {
            InitializeComponent(); // Initialisiert die Komponenten
        }

        // Zurück Button Logik
        private void BTN_Back_Click(object sender, EventArgs e)
        {
            this.Close(); // Schließt das Fenster
        }

        // Hilfetexte
        private void BTN_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wählen Sie im oberen Bereich aus ob Sie einen Text Komprimieren oder einen Binärcode mit dem Werteschlüssel Dekomprimieren wollen.\nIm unteren Bereich müssen Sie die gewünschte Eingabe eingeben.\r\n", "Hilfe"); // Hilfetext
        }

        // Start Button Logik
        private void BTN_Start_Click(object sender, EventArgs e)
        {
            if (TB_Input.Text == "")
            {
                MessageBox.Show("Eingabe ist leer!");                                      // Fehlermeldung, wenn keine Eingabe vorhanden ist
            }

            else if ((RB_Dekomprimieren.Checked == true && CheckingInput() == false))
            {
                MessageBox.Show("Ungültige Eingabe!");                                      // Fehlermeldung, wenn eine falsche Eingabe vorhanden ist
            }

            else
            {
                // Komprimieren
                if (RB_Komprimieren.Checked == true && RB_Dekomprimieren.Checked == false)
                {
                    string? text = TB_Input.Text;                                           // Text wird eingelesen
                    string? encodedText = Encode(text);                                     // Text wird verschlüsselt
                    TB_Output.Text = encodedText;                                           // Ausgabe des komprimierten Textes

                    string pathTable = GeneratePathTable(text);                             // Pfadtabelle wird erstellt
                    TB_PathOut.Text = pathTable;                                            // Ausgabe der Pfadtabelle
                    TB_PathIn.Text = "";                                                    // Eingabe der Pfadtabelle wird gelöscht
                }

                // Dekomprimieren
                else if (RB_Dekomprimieren.Checked == true && RB_Komprimieren.Checked == false)
                {
                    string? input = TB_Input.Text;                                          // Eingabe wird eingelesen
                    string? pathInput = TB_PathIn.Text;                                     // Pfadtabelle wird eingelesen

                    Dictionary<string, char> pathToLetter = new Dictionary<string, char>(); // Pfadtabelle wird erstellt

                    ParsePathInput(pathInput, pathToLetter);                                // Pfadtabelle wird geparst

                    string? output = Decompress(input, pathToLetter);                       // Text wird dekomprimiert

                    TB_Output.Text = output;                                                // Ausgabe des dekomprimierten Textes
                    TB_PathOut.Text = "";                                                   // Ausgabe der Pfadtabelle wird gelöscht
                }
            }
        }

        // Input beim Dekomprimieren überprüfen
        private bool CheckingInput()
        {
            for (int i = 0; i < TB_Input.Text.Length; i++)
            {
                if (TB_Input.Text[i] != '0' && TB_Input.Text[i] != '1')
                {
                    return false;
                }
            }

            return true;
        }

        // Pfadtabelle erstellen
        private string GeneratePathTable(string text)
        {
            HuffmanTree tree = new();                                                       // Baum wird erstellt
            tree.BuildTree(text);
            Dictionary<char, string> encodingTable = tree.BuildEncodingTable(tree.Root);    // Pfadtabelle wird erstellt

            var values = encodingTable.Select(kv => $"{kv.Key}{kv.Value}");
            string pathTable = string.Join(',', values);

            return pathTable;                                                               // Pfadtabelle wird zurückgegeben
        }

        // Entschlüsseln
        private string Encode(string source)
        {
            HuffmanTree tree = new();                                                       // Baum wird erstellt
            tree.BuildTree(source); 
            Dictionary<char, string> encodingTable = tree.BuildEncodingTable(tree.Root);    // Pfadtabelle wird erstellt

            string encoded = "";                                                            // Variable wird erstellt
            foreach (char c in source)
            {
                encoded += encodingTable[c];
            }

            return encoded;                                                                 // Variable wird zurückgegeben
        }

        // Knoten Klasse
        public class HuffmanNode
        {
            public char Symbol
            {
                get; set;
            }
            public int Frequency
            {
                get; set;
            }
            public HuffmanNode Left
            {
                get; set;
            }
            public HuffmanNode Right
            {
                get; set;
            }
        }

        // Baum Klasse
        public class HuffmanTree
        {
            public HuffmanNode Root
            {
                get; set;
            }

            public static Dictionary<char, int> BuildFrequencyTable(string source)  // Häufigkeitstabelle wird erstellt
            {
                var freqTable = new Dictionary<char, int>();
                foreach (var chr in source)
                {
                    if (!freqTable.ContainsKey(chr))
                        freqTable.Add(chr, 0);
                    freqTable[chr]++; 
                }
                return freqTable;                                                   // Häufigkeitstabelle wird zurückgegeben
            }

            public void BuildTree(string source)
            {
                var freqTable = BuildFrequencyTable(source);                                                // Häufigkeitstabelle wird erstellt
                var priorityQueue = new PriorityQueue<HuffmanNode>(Comparer<HuffmanNode>.Create((x, y) => x.Frequency - y.Frequency));  // Prioritätswarteschlange wird erstellt

                foreach (var item in freqTable)
                {
                    priorityQueue.Push(new HuffmanNode() { Symbol = item.Key, Frequency = item.Value });    // Knoten werden erstellt
                }

                while (priorityQueue.Count > 1)                                                             // Knoten werden sortiert
                {
                    var left = priorityQueue.Pop(); 
                    var right = priorityQueue.Pop();

                    var parent = new HuffmanNode()                                                          // Knoten werden erstellt
                    {
                        Symbol = '\0',
                        Frequency = left.Frequency + right.Frequency,
                        Left = left,
                        Right = right
                    };

                    priorityQueue.Push(parent);                                                             // Knoten werden in die Warteschlange gepusht
                }

                Root = priorityQueue.Pop();                                                                 // Wurzel wird erstellt
            }

            public Dictionary<char, string> BuildEncodingTable(HuffmanNode node, string prefix = "")    // Pfadtabelle wird erstellt
            {
                var table = new Dictionary<char, string>();

                if (node.Left == null && node.Right == null)                                            // Knoten werden erstellt
                {
                    table.Add(node.Symbol, prefix);                                                     // Knoten werden in die Pfadtabelle gepusht
                }
                else
                {
                    if (node.Left != null)                                                              // Knoten werden erstellt
                    {
                        foreach (var pair in BuildEncodingTable(node.Left, prefix + "0"))               // Knoten werden in die Pfadtabelle gepusht
                        {
                            table.Add(pair.Key, pair.Value);
                        }
                    }

                    if (node.Right != null)                                                             // Knoten werden erstellt
                    {
                        foreach (var pair in BuildEncodingTable(node.Right, prefix + "1"))              // Knoten werden in die Pfadtabelle gepusht
                        {
                            table.Add(pair.Key, pair.Value); 
                        }
                    }
                }

                return table;                                                                           // Pfadtabelle wird zurückgegeben
            }

            public class PriorityQueue<T> 
            {
                private List<T> data;           // Warteschlange wird erstellt
                private IComparer<T> comparer;  // Vergleich wird erstellt

                public PriorityQueue(IComparer<T> comparer) 
                {
                    this.comparer = comparer;   // Vergleich wird erstellt
                    this.data = new List<T>();  // Warteschlange wird erstellt
                }

                public void Push(T item)        // Element wird in die Warteschlange gepusht
                {
                    data.Add(item); 
                    int ci = data.Count - 1;    // Element wird erstellt
                    while (ci > 0)              // Element wird sortiert
                    {
                        int pi = (ci - 1) / 2; 
                        if (comparer.Compare(data[ci], data[pi]) >= 0) break;
                        T tmp = data[ci]; data[ci] = data[pi]; data[pi] = tmp;
                        ci = pi; 
                    }
                }

                public T Pop()          // Element wird aus der Warteschlange gepopt
                {
                    T frontItem = data[0]; 
                    int li = data.Count - 1;
                    data[0] = data[li];
                    data.RemoveAt(li);

                    --li;
                    int pi = 0; 
                    while (true)        // Element wird sortiert
                    {
                        int ci = pi * 2 + 1;
                        if (ci > li) break;
                        int rc = ci + 1;
                        if (rc <= li && comparer.Compare(data[rc], data[ci]) < 0) ci = rc;
                        if (comparer.Compare(data[pi], data[ci]) <= 0) break;
                        T tmp = data[pi]; data[pi] = data[ci]; data[ci] = tmp;
                        pi = ci;
                    }
                    return frontItem;   // Element wird zurückgegeben
                }

                public int Count 
                {
                    get
                    {
                        return data.Count; // Anzahl der Elemente wird zurückgegeben
                    }
                }
            }
        }

        // Pfad splitten
        private void ParsePathInput(string pathInput, Dictionary<string, char> pathToLetter) // Pfad wird gesplittet und in die Pfadtabelle gepusht
        {
            string[] entries = pathInput.Split(',', StringSplitOptions.RemoveEmptyEntries); 

            foreach (string entry in entries) 
            {
                char letter = entry[0]; 
                string path = entry[1..];

                pathToLetter[path] = letter;
            }
        }

        // Dekomprimieren
        private string Decompress(string input, Dictionary<string, char> pathToLetter) // Binärcode wird in Text umgewandelt und zurückgegeben
        {
            StringBuilder output = new();
            string currentPath = "";

            foreach (char bit in input)
            {
                currentPath += bit;

                if (pathToLetter.ContainsKey(currentPath)) 
                {
                    char letter = pathToLetter[currentPath];
                    output.Append(letter);
                    currentPath = "";
                }
            }

            return output.ToString(); // Text wird zurückgegeben
        }

        // Hilfetexte
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Geben Sie hier den Text zum Komprimieren ein oder den Binärcode zum Dekomprimieren\r\n", "Hilfe für Eingabe"); // Hilfetexte
        }

        // Hilfetexte
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Geben Sie hier den Werteschlüssel zum Dekomprimieren ein, beim Kompriemieren leer lassen\r\n", "Hilfe für Eingabe"); // Hilfetexte
        }

        // Hilfetexte
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hier bekommen Sie beim Komprimieren den Binärcode und beim Dekomprimieren den Originalen Text", "Hilfe für Ausgabe"); // Hilfetexte
        }

        // Hilfetexte
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hier bekommen Sie beim Komprimieren den WerteSchlüssel, beim Komprimieren ist es leer", "Hilfe für Ausgabe"); // Hilfetexte
        }

        // Methode für Dark Mode
        private void checkBox1_CheckedChanged(object sender, EventArgs e) // Dark Mode wird aktiviert oder deaktiviert
        {
            if (checkBox1.Checked == true)
            {
                BackColor = Color.Black;
                LBL_Eingabe.ForeColor = Color.White;
                LBL_Ausgabe.ForeColor = Color.White;
                LBL_Titel.ForeColor = Color.White;
                RB_Dekomprimieren.ForeColor = Color.White;
                RB_Komprimieren.ForeColor = Color.White;
                checkBox1.ForeColor = Color.White;
            }

            else
            {
                BackColor = Color.White;
                LBL_Eingabe.ForeColor = Color.Black;
                LBL_Ausgabe.ForeColor = Color.Black;
                LBL_Titel.ForeColor = Color.Black;
                RB_Dekomprimieren.ForeColor = Color.Black;
                RB_Komprimieren.ForeColor = Color.Black;
                checkBox1.ForeColor = Color.Black;
            }
        }
    }
}
