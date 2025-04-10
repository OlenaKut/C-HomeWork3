using System;
using System.Collections.Generic;


namespace Vehicle;

public class Vehicle
{
    private string brand = string.Empty;
    private string model = string.Empty;
    private int year;
    private double weight;




    public string Brand
    {
        get => brand;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length <= 2 || value.Length >= 20)
                throw new ArgumentException("Brand must be between 2 and 20 characters.");
            brand = value;
        }
    }

    public string Model
    {
        get => model;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length <= 2 || value.Length >= 20)
                throw new ArgumentException("Model must be between 2 and 20 characters.");
            model = value;
        }
    }

    public int Year
    {
        get => year;
        set
        {
            int currentYear = DateTime.Now.Year;
            if (value < 1886 || value > currentYear)
                throw new ArgumentException($"Year must be between 1886 and {currentYear}.");
            year = value;
        }
    }

    public double Weight
    {
        get => weight;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Weight must be a positive value.");
            weight = value;
        }
    }

    public override string ToString()
    {
        return $"Brand: {Brand}, Model: {Model}, Year: {Year}, Weight: {Weight}kg";
    }

}