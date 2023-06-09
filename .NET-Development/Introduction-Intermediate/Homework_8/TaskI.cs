using System;

abstract class Planet
{
    protected string Name { get; set; }
    protected int DistanceFromSun { get; set; }

    abstract void ReportAboutPlanet()
    {

    }

    abstract void ReportAboutMovement()
    {

    }

    abstract void ReportAboutLife()
    {

    }
}

class Earth : Planet
{

}

class Moon : Planet
{

}

class Mars : Planet
{

}

class Astrology
{
    static void Main(string[] args)
    {

    }
}