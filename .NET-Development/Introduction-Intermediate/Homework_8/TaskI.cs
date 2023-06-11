namespace Task
{
    abstract class Planet
    {
        protected string Name { get; set; }
        protected int DistanceFrom { get; set; }

        public abstract void ReportAboutMovement();

        public abstract void ReportAboutLife();
    }

    class Earth : Planet
    {
        public Earth(string name, int distance)
        {
            this.Name = name;
            this.DistanceFrom = distance;
        }

        public override void ReportAboutMovement()
        {
            Console.WriteLine($"Planet {Name} moves around the Sun, distance between the Sun and {Name} is {DistanceFrom} million KM!");
        }

        public override void ReportAboutLife()
        {
            Console.WriteLine($"Planet {Name} has life, there are 8 billion people and estimated 7.7 million known animal species on {Name}!");
        }
    }

    class Moon : Planet
    {
        public Moon(string name, int distance)
        {
            this.Name = name;
            this.DistanceFrom = distance;
        }

        public override void ReportAboutMovement()
        {
            Console.WriteLine($"The {Name} is only natural satellite of Earth on average distance {DistanceFrom} thousands KM!");
        }

        public override void ReportAboutLife()
        {
            Console.WriteLine($"There is no life on {Name}, but 12 humans have walked on {Name} as a part of NASA's missions!");
        }
    }

    class Astrology
    {
        static void Main(string[] args)
        {
            string name = "Earth";
            int dist = 150;
            Earth Earth = new Earth(name, dist);

            name = "Moon";
            dist = 384;
            Moon Moon = new Moon(name, dist);

            Planet[] Planets =
            {
                Earth, Moon,
            };

            foreach(var planet in Planets )
            {
                planet.ReportAboutLife();
                planet.ReportAboutMovement();
                Console.WriteLine();
            }
        }
    }
}