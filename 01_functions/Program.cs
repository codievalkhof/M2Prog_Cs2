namespace _01_functions;

class Program
{
    static void Main(string[] args)
    {
       Program Program = new Program();//string//
       Program.run();//je noemt de variable run//
    }

    internal void run(){
        Console.WriteLine("kaas");
        Vraag1();
        Vraag2();
        Vraag3();
        Vraag4();
        Vraag5();
        Vraag6();
    }

    internal void Vraag1(){
    Console.WriteLine("how long do you think you'd survive in a zombie apocalypse?");
    string antwoord = Console.ReadLine();
    Console.WriteLine(antwoord);}

     internal void Vraag2(){
    Console.WriteLine("what weapon would you use");
    string antwoord = Console.ReadLine();
    Console.WriteLine(antwoord);}

     internal void Vraag3(){
    Console.WriteLine("where would you build a base");
    string antwoord = Console.ReadLine();
    Console.WriteLine(antwoord);}

     internal void Vraag4(){
    Console.WriteLine("would you be solo or in a team");
    string antwoord = Console.ReadLine();
    Console.WriteLine(antwoord);}

     internal void Vraag5(){
    Console.WriteLine("where would you gather supplies");
    string antwoord = Console.ReadLine();
    Console.WriteLine(antwoord);}

     internal void Vraag6(){
    Console.WriteLine("what time would you go out");
    string antwoord = Console.ReadLine();
    Console.WriteLine(antwoord);}
}
