
namespace ConsoleApp11
{
    
    internal class Program {

        
        static void Main(string[] args) {
            Uzytkownik admin = new Uzytkownik("Jamnik","Dono");
            Uzytkownik gosc = new Uzytkownik("York", "Pono");
            Console.WriteLine("Podaj login");
            string login = (Console.ReadLine());
            Console.WriteLine("Podaj hasło");
            string haslo = (Console.ReadLine());
                if (admin.Zaloguj(login,haslo) || gosc.Zaloguj(login,haslo)) {
                    List<string> hist = new List<string>();
                    string dzialanie = "";
                    int histLicz = 0;
                    do {
                        Console.WriteLine("Chcesz dodawać, odejmować, mnożyć czy dzielić? możesz też zakończyć program pisząc koniec. Chcesz zobaczyć hitorię? wpisz historia");
                        dzialanie = Console.ReadLine();
                        dzialanie = dzialanie.ToLower();
                        if (dzialanie != "koniec") {
                            if (dzialanie != "historia") {
                                histLicz++;
                                Console.WriteLine("Podaj pierwszą liczbę");
                                float a = float.Parse(Console.ReadLine());
                                hist.Add(a.ToString());
                                Console.WriteLine("Podaj drugą liczbę");
                                float b = float.Parse(Console.ReadLine());
                                hist.Add(b.ToString());

                                {
                                    switch (dzialanie) {
                                        case "dodawać":
                                            hist.Add("+");
                                            float wynik = dodaj(a, b);
                                            Console.WriteLine(wynik);
                                            hist.Add(wynik.ToString());
                                            break;
                                        case "odejmować":
                                            hist.Add("-");
                                            wynik = odejmuj(a, b);
                                            Console.WriteLine(wynik);
                                            hist.Add(wynik.ToString());
                                            break;
                                        case "mnożyć":
                                            hist.Add("*");
                                            wynik = mnoz(a, b);
                                            Console.WriteLine(wynik);
                                            hist.Add(wynik.ToString());
                                            break;
                                        case "dzielić":
                                            hist.Add("/");
                                            if (b == 0) {
                                                Console.WriteLine("Nie można dzielić przez zero.");
                                            } else {
                                                wynik = dziel(a, b);
                                                Console.WriteLine(wynik);
                                                hist.Add(wynik.ToString());
                                            }
                                            break;
                                        default:
                                            Console.WriteLine("Nie poprawna operacja");
                                            break;
                                    }
                                }
                            }
                            if (dzialanie == "historia") {


                                    
                                    for (int i = 0; i != histLicz; i++) {
                                        Console.WriteLine(hist[i * 4 + 0] + " " + hist[i * 4 + 2] + " " + hist[i * 4 + 1] + " = " + hist[i * 4 + 3]);
                                    }
                                   

                            }
                        }

                        
                    } while (dzialanie != "koniec");

                


                } else {
                    Console.WriteLine("Błędny login lub hasło");
                }
            


        }
        static float dodaj(float a, float b) {


            return a + b;
        }
        static float odejmuj(float a, float b) {


            return a - b;
        }
        static float mnoz(float a, float b) {


            return a * b;
        }
        static float dziel(float a, float b) {


            return a / b;
        }

        



        class Uzytkownik 
        {

          public string Login;
          public string Haslo;
          private Uzytkownik(string login, string haslo) 
            {
                Login = login;
                Haslo = haslo;
            }


         private bool Zaloguj(string podanyLogin, string podaneHaslo) 
            {
                return Login == podanyLogin && Haslo == podaneHaslo;
            }
        
        }

    }
}
