using Domain;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp96.Services
{
    public static class S
    {
        public static DataAutogenerator.NetCore.DataAutogenerator _dataAutogenerator = new DataAutogenerator.NetCore.DataAutogenerator ();

        public static AccountService AccountService = new AccountService ();
        public static UsersService UsersService = new UsersService ();
        public static UsersZdjeciaService UsersZdjeciaService = new UsersZdjeciaService ();
        public static RolesService RolesService = new RolesService ();
        public static IdentityUserRolesService IdentityUserRolesService = new IdentityUserRolesService ();
        public static RejestratorPracyService RejestratorPracyService = new RejestratorPracyService ();

        public static LekarzeService LekarzeService = new LekarzeService ();
        public static LekarzeSpecjalizacjeService LekarzeSpecjalizacjeService = new LekarzeSpecjalizacjeService ();
        public static PacjenciService PacjenciService = new PacjenciService ();
        public static RejestracjeService RejestracjeService = new RejestracjeService ();
        public static SpecjalizacjeService SpecjalizacjeService = new SpecjalizacjeService ();
        public static PacjenciZdjeciaService PacjenciZdjeciaService = new PacjenciZdjeciaService ();
        public static LekarzeZdjeciaService LekarzeZdjeciaService = new LekarzeZdjeciaService ();


        public static ApplicationUser User { get; set; }
        public static ApplicationUser ZalogowanyUser { get; set; }
        public static ApplicationRole Role { get; set; }
        public static ApplicationUserZdjecie UserZdjecie { get; set; }
        public static RejestratorPracy RejestratorPracy { get; set; }
        public static Lekarz Lekarz { get; set; }
        public static LekarzSpecjalizacje LekarzSpecjalizacje { get; set; }
        public static Pacjent Pacjent { get; set; }
        public static Rejestracja Rejestracja { get; set; }
        public static Specjalizacja Specjalizacja { get; set; }
         


        public static string UserId { get; set; } 
        public static string RoleId { get; set; }
        public static string UserZdjecieId { get; set; }
        public static string RejestratorPracyId { get; set; }
        public static string LekarzId { get; set; }
        public static string LekarzSpecjalizacjeId { get; set; }
        public static string PacjentId { get; set; }
        public static string RejestracjaId { get; set; }
        public static string SpecjalizacjaId { get; set; }
        public static string LekarzZdjecieId { get; set; }
        public static string PacjentZdjecieId { get; set; }



        public static List <string> Zdjecia = new List<string> ();
        public static List <string> ListaRol = new List<string> ();




        public static int Index = 1;
        public static string IndexCounter
        {
            get
            {
                Index++;
                return $"{Index}";
            }
        }


        public static void SetDataGridViewStyles (DataGridView dataGridView)
        {
            dataGridView.AllowUserToOrderColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToResizeColumns = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.RowHeadersVisible = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ReadOnly = false;
            dataGridView.MultiSelect = false;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.BackgroundColor = Color.White;

            dataGridView.ColumnHeadersHeight = 50;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 245, 245);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
             
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

        }

        public static void SetDataGridViewStyles2 (DataGridView dataGridView)
        {
            dataGridView.AllowUserToOrderColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToResizeColumns = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.RowHeadersVisible = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ReadOnly = true;
            dataGridView.MultiSelect = false;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.BackgroundColor = Color.White;

            dataGridView.ColumnHeadersHeight = 45;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb (240,240,240);
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240);
            //dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.MediumAquamarine;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView.DefaultCellStyle.BackColor = Color.White;

        }
          
        public static void SetDataGridViewStylesOrders (DataGridView dataGridView)
        {
            dataGridView.AllowUserToOrderColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToAddRows = true;
            dataGridView.AllowUserToDeleteRows = false;

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.RowHeadersVisible = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ReadOnly = false;
            dataGridView.MultiSelect = false;
            dataGridView.EnableHeadersVisualStyles = false;

            dataGridView.ColumnHeadersHeight = 50;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            dataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.White;

        }



        public static bool IsValid (List<TextBox> lista)
        {
            bool result = false;
            foreach (TextBox textBox in lista)
            {
                if (!string.IsNullOrEmpty(textBox.Text))
                    result = true;
                else
                    result = false;
            }
            return result;
        }




        public static void ClearPanelContainer (Panel panelContainer)
        {
            panelContainer.Controls.Clear();
        }


        // Ustawienie koloru dla jednego buttona
        public static void SetColor (Panel panelNavigation)
        {
            foreach (Control control in panelNavigation.Controls)
            {
                if (control is Button)
                {
                    Button button = control as Button;
                    button.Click += (s, e) =>
                    {
                        SetColors(panelNavigation);
                        Button b = (Button) s;
                        b.BackColor = Color.FromArgb(180, 180, 180);
                        b.ForeColor = Color.Black;
                    };
                }
            }
        }

        // Ustawienie kolorów dla wszystkich buttonów
        public static void SetColors (Panel panelNavigation)
        {
            foreach (Control control in panelNavigation.Controls)
            {
                if (control is Button)
                {
                    Button button = control as Button;
                    button.BackColor = Color.FromArgb(215, 215, 215);
                    button.ForeColor = Color.Black;
                    button.FlatAppearance.MouseDownBackColor = Color.FromArgb(205, 205, 205);
                }
            }

        }


        public static void SetPictureBoxBorder (PictureBox pictureBox)
        {
            pictureBox.Paint += (s,e) =>
            {
                e.Graphics.DrawRectangle (new Pen (Brushes.Black, 2), 
                    new Rectangle (
                        new Point (0,0), 
                        new Size (pictureBox.Width, pictureBox.Height)
                        ));
            };
        }


        public static Image GetImage (string sciezka)
        { 
            WebRequest webreq = WebRequest.Create(sciezka);
            WebResponse webres = webreq.GetResponse();
            Stream stream = webres.GetResponseStream(); 
            Image image = Image.FromStream(stream);
            stream.Close();

            return image;
        }


        public static byte[] GetBytes (string filePath)
        {
            byte [] bytes = new byte [0];
            using (Stream stream = File.OpenRead(filePath))
            {
                bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                string extension = new FileInfo (filePath).Extension;
                return bytes;
            }
        }


        public static void DisplayFile (byte[] data, string filePath)
        {
            if (data.Length > 0 && !string.IsNullOrEmpty(filePath))
            {
                string extension = new FileInfo (filePath).Extension;
                switch (extension)
                {
                    case ".txt":
                        /*MemoryStream ms = new MemoryStream (data);
                        string streamReader = new StreamReader (ms).ReadToEnd ();
                        MessageBox.Show (streamReader);*/

                        //File.WriteAllBytes(@"F:\data2.txt", data); 
                        Process.Start(@"F:\data1.txt");
                        //MessageBox.Show (Convert.ToBase64String (data));
                        break;

                    case ".jpg":
                        /*DisplayPhoto dpJpg = new DisplayPhoto (data);
                        dpJpg.ShowDialog();*/
                        break;

                    case ".png": 
                        break;

                    case ".pdf":

                        break;

                    case ".docx":
                        MemoryStream msWord = new MemoryStream (data);
                        /*string streamReaderWord = new StreamReader (msWord).ReadToEnd ();
                        var create = new FileStream (@"F:\file.docx", FileMode.Create);
                        var open = new FileStream ("", FileMode.Open);
                        var sr = new StreamWriter (msWord);*/

                        File.WriteAllBytes(@"F:\data1.txt", data);

                        //MessageBox.Show(streamReaderWord);
                        break;

                }
            }
        }



        /// <summary>
        /// Wyświetla listę wybranych zdjęć przez użytkownika w ListBox'ie
        /// </summary>
        public static void SetItemsInListBox (List<string> items, ListBox listBoxZdjecia)
        { 
            listBoxZdjecia.Items.Clear ();
            foreach (var item in items)
                listBoxZdjecia.Items.Add (item);
            if (listBoxZdjecia.Items.Count > 0)
                listBoxZdjecia.SelectedIndex = 0;
        }


        /// <summary>
        /// Aktualizuje listę ze zdjęciami w zmiennej Zdjecia
        /// </summary>
        public static void SetItemsFromListBoxToListZdjecia (ListBox listBoxZdjecia)
        {
            Zdjecia.Clear ();
            foreach (var item in listBoxZdjecia.Items)
                Zdjecia.Add (item.ToString ());
        }


         

        /// <summary>
        /// Wyświetla wszystkie role w paneu w postaci CheckBox'ow
        /// </summary> 
        public static async void DisplayAllRoles (Panel panelUprawnienia)
        {
            try
            {
                Index = 0;
                var roles = (await RolesService.GetAll ())
                        .Select (s=> s.Name)
                        .ToList ();

                foreach (var role in roles)
                {
                    CheckBox checkBox = new CheckBox ()
                    {
                        Text = role,
                        Location = new Point (5, S.Index * 40),
                        Size = new Size (150, 40)
                    };
                    checkBox.CheckedChanged += (s, e) =>
                    {
                        CheckBox ch = (CheckBox) s;
                        if (ch.Checked)
                            ListaRol.Add(ch.Text);
                        else
                            ListaRol.Remove(ch.Text);
                    };
                    panelUprawnienia.Controls.Add(checkBox);

                    Index++;
                }
            }
            catch { }
        }



        /// <summary>
        /// Sprawdza do jakich róln należy dany użytkownik.
        /// Wykorzystywane w sekcjach edycyjnych
        /// </summary>
        public static async void DisplayAllRolesISprawdzCzyDoNiejNalezy (Panel panelUprawnienia, ApplicationUser user)
        {
            try
            {
                Index = 0;
                var roles = await RolesService.GetAll ();
                foreach (var role in roles)
                {
                    CheckBox checkBox = new CheckBox ()
                    {
                        Text = role.Name,
                        Location = new Point (5, S.Index * 40),
                        Size = new Size (300, 40)
                    };

                    // Sprawdzenie czy rola jest przypisana do użytkownika
                    IdentityUserRole <string> userRole = new IdentityUserRole<string> ();
                    userRole = (await IdentityUserRolesService.GetAll ())
                        .FirstOrDefault (f=> f.UserId == user.Id && f.RoleId == role.Id); 
                    if (userRole != null)
                        checkBox.Checked = true;
                    else
                        checkBox.Checked = false;


                    checkBox.CheckedChanged += async (s, e) =>
                    {
                        userRole = (await IdentityUserRolesService.GetAll())
                            .FirstOrDefault(f => f.UserId == user.Id && f.RoleId == role.Id);

                        CheckBox ch = (CheckBox) s;
                        if (ch.Checked)
                        {
                            // dodanie usera do roli 
                            IdentityUserRole <string> ur = new IdentityUserRole<string> () { RoleId = role.Id, UserId = user.Id };
                            await IdentityUserRolesService.Create(ur);
                        }
                        else
                        {
                            // usunięcie roli  
                            if (userRole != null)
                            { 
                                await IdentityUserRolesService.Delete(userRole.UserId, userRole.RoleId);
                            }
                        }
                    };
                    panelUprawnienia.Controls.Add(checkBox);

                    Index++;
                }
            }
            catch { }
        }


        /// <summary>
        /// Sprawdza w jakiej roli jest dany użytkownik
        /// </summary>
        public static async Task<bool> LoggedUserInRole (string roleName)
        {
            bool value = false;

            if (ZalogowanyUser != null)
            {
                var getRoles = await GetUserRoles (ZalogowanyUser);
                foreach (var role in getRoles)
                    if (role == roleName)
                        value = true;
            }

            return value;
        }


        /// <summary>
        /// Pobiera wszystkie role użytkownika
        /// </summary>
        public static async Task <List<string>> GetUserRoles (ApplicationUser user)
        {
            Index = 0;
            List <string> userRoles = new List<string> ();
            var roles = await RolesService.GetAll ();
            foreach (var role in roles)
            {
                // Sprawdzenie czy rola jest przypisana do użytkownika
                IdentityUserRole <string> userRole = (await IdentityUserRolesService.GetAll ())
                        .FirstOrDefault (f=> f.UserId == user.Id && f.RoleId == role.Id);
                if (userRole != null)
                    userRoles.Add(role.Name);
                Index++;
            }
            return userRoles;
        }

        /// <summary>
        /// Pobiera wszystkie role użytkownika w formie stringa
        /// </summary>
        public static async Task <string> GetUserRolesString (ApplicationUser user)
        {
            Index = 0;
            List <string> userRoles = new List<string> ();
            var roles = await RolesService.GetAll ();
            foreach (var role in roles)
            {
                // Sprawdzenie czy rola jest przypisana do użytkownika
                IdentityUserRole <string> userRole = (await IdentityUserRolesService.GetAll ())
                        .FirstOrDefault (f=> f.UserId == user.Id && f.RoleId == role.Id);
                if (userRole != null)
                    userRoles.Add(role.Name);
                Index++;
            }
            return string.Concat(userRoles);
        }


        /// <summary>
        /// Przypisuje użytkownika do istniejącej roli
        /// </summary>
        public static async void PrzypiszUzytkownikaDoRoli (string rolaName, ApplicationUser user)
        {            
            ApplicationRole role = (await RolesService.GetAll ())
                .FirstOrDefault (f=> f.Name == rolaName);
            if (role != null)
            {
                IdentityUserRole <string> userRole = new IdentityUserRole<string>()
                {
                    UserId = user.Id,
                    RoleId = role.Id
                };
                await IdentityUserRolesService.Create (userRole);
            }
        }


        /*public static List<AppUser> PokazWszystkichUzytkownikowZrola (string roleName)
        {
            S.Index = 0;
            List <AppUser> appUsers = new List<AppUser> ();
            ApplicationRole role = _context.Roles.FirstOrDefault (f=> f.Name == roleName);
            if (role != null)
            {
                var userRoles = _context.UserRoles.Where (w=> w.RoleId == role.Id).ToList ();
                foreach (var userRole in userRoles)
                {
                    var user = _context.Users.FirstOrDefault (f=> f.Id == userRole.UserId);
                    if (user != null)
                    {
                        AppUser appUser = new AppUser ()
                        {
                            Imie = user.Imie,
                            Nazwisko = user.Nazwisko
                        };
                        appUsers.Add(appUser);
                    }
                }
            }
            return appUsers;
        }*/




         
        /// <summary>
        /// Wyświetla wszystkie specjalizacje oraz poprzez zaznaczenie checkBoxa umożlia przypisanie jej
        /// do danego lekarza
        /// </summary>
        public static List <string> ListaSpecjalizacji = new List<string> ();
        public static async void WyswietlSpecjalizacje (Panel panelSpecjalizacje)
        {
            try
            {
                Index = 0;
                Specjalizacja = null; 
                var specjalizacje = await SpecjalizacjeService.GetAll (); 
                foreach (var specjalizacja in specjalizacje)
                {
                    CheckBox checkBox = new CheckBox ()
                    {
                        Text = specjalizacja.Nazwa,
                        Location = new Point (5, Index * 40),
                        Size = new Size (panelSpecjalizacje.Width - 20, 40)
                    };
                    checkBox.CheckedChanged += async (s, e) =>
                    {
                        CheckBox ch = (CheckBox) s;
                         

                        if (ch.Checked) 
                            ListaSpecjalizacji.Add (ch.Text); 
                        else 
                            ListaSpecjalizacji.Remove(ch.Text); 
                    };
                    panelSpecjalizacje.Controls.Add(checkBox);

                    Index++;
                }
            }
            catch { }
        }

        /// <summary>
        /// Przypisywanie i usuwanie specjalizacji do danego lekarza
        /// </summary>
        public static async void PrzypiszUsunWybraneSpecjalizacje ()
        {
            // Najpierw program usuwa wszystkie specjalizacje jakei są przypisane do danego lekarza
            foreach (var nazwaSpecjalizacji in (await SpecjalizacjeService.GetAll ()))
            {
                LekarzSpecjalizacje = (await LekarzeSpecjalizacjeService.GetAll ())
                    .FirstOrDefault (f=> f.LekarzId == LekarzId);
                if (LekarzSpecjalizacje != null)
                    await LekarzeSpecjalizacjeService.Delete (LekarzSpecjalizacje.LekarzId, LekarzSpecjalizacje.SpecjalizacjaId);
            }

            // a poetm przypisuje tylko te wybrane
            foreach (var nazwaSpecjalizacji in ListaSpecjalizacji)
            {
                Specjalizacja = (await SpecjalizacjeService.GetAll())
                                       .FirstOrDefault(f => f.Nazwa == nazwaSpecjalizacji);
                if (Specjalizacja != null)
                {
                    LekarzSpecjalizacje = new LekarzSpecjalizacje()
                    {
                        LekarzId = LekarzId,
                        SpecjalizacjaId = Specjalizacja.SpecjalizacjaId
                    };
                    await LekarzeSpecjalizacjeService.Create(LekarzSpecjalizacje);
                }
            }
        }

        /// <summary>
        /// Program na nowo wyświetla CheckBox'y i sprawdza która specjalizacja należy do danego lekarza,
        /// jeśli należy do go zaznacza. 
        /// Wykorzystywane w formularzu edycyjnym
        /// </summary>

        public static async void SprawdzDoJakichSpecjalizacjiPrzypisanyJestDanyLekarz (Panel panelSpecjalizacje, Lekarz lekarz)
        {
            try
            {
                Index = 0; 
                foreach (var specjalizacja in await SpecjalizacjeService.GetAll())
                {
                    CheckBox checkBox = new CheckBox ()
                    {
                        Text = specjalizacja.Nazwa,
                        Location = new Point (5, Index * 40),
                        Size = new Size (panelSpecjalizacje.Width - 20, 40)
                    };
                      
                    LekarzSpecjalizacje lekarzSpecjalizacja = (await LekarzeSpecjalizacjeService.GetAll ())
                        .FirstOrDefault (f=> f.LekarzId == lekarz.LekarzId && f.SpecjalizacjaId == specjalizacja.SpecjalizacjaId);
                    if (lekarzSpecjalizacja == null)
                        checkBox.Checked = false;
                    else 
                        checkBox.Checked = true;


                    checkBox.CheckedChanged += async (s, e) =>
                    {
                        CheckBox ch = (CheckBox) s;  

                        LekarzSpecjalizacje = new LekarzSpecjalizacje()
                        {
                            LekarzId = lekarz.LekarzId,
                            SpecjalizacjaId = specjalizacja.SpecjalizacjaId
                        };

                        if (ch.Checked)
                        {
                            await LekarzeSpecjalizacjeService.Create(LekarzSpecjalizacje); 
                        }
                        else
                        {
                            await LekarzeSpecjalizacjeService.Delete(LekarzSpecjalizacje.LekarzId, LekarzSpecjalizacje.SpecjalizacjaId);
                        }
                    };
                    panelSpecjalizacje.Controls.Add(checkBox);

                    Index++;
                }
            }
            catch { }
        }





        public static bool TerminKonczySieWtymTygodniu (DateTime zakonczenie)
        {
            var dni = (zakonczenie - DateTime.Now).Days;
            if (dni >= 0 && dni <= 7)
                return true;
            else
                return false;
        }

        public static bool TerminKonczySieWtymMiesiacu (DateTime zakonczenie)
        {
            var dni = (zakonczenie - DateTime.Now).Days;
            if (dni >= 0 && dni <= 30)
                return true;
            else
                return false;
        }



    }
}
