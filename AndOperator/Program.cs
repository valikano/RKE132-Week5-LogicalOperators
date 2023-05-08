//temp <= 0 - freezing cold
//temp > 0 AND temp <= 10 - cold
//temp > 10 AND temp <= 15 - chilly
//temp >= 15 AND temp < 20 - Warm
//temp >= 20 AND temp < 30 - hot
//temp >= 30 - boiling hot


//Math >= 90; Bio >= 90; Chemistry >= 90;

int math, biology, chemistry;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if (math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congrats! Your got accepted");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}