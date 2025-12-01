using Microsoft.EntityFrameworkCore;
using RentalAPI.Domain.Entities;
using RentalAPI.Domain.Enums;
using BCrypt.Net;

namespace RentalAPI.Infrastructure.Persistence;

public static class DatabaseSeeder
{
    public static async Task SeedAsync(RentalDbContext context)
    {
        // Check if database is already seeded
        if (await context.Users.AnyAsync())
        {
            return; // Database already has data
        }

        // Seed Users
        var adminUser = new User
        {
            Id = Guid.NewGuid(),
            Username = "admin",
            Email = "admin@rental.com",
            PasswordHash = BCrypt.Net.BCrypt.HashPassword("Admin@123"),
            FullName = "Administrator",
            Role = UserRole.Admin,
            IsActive = true,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        var attendantUser = new User
        {
            Id = Guid.NewGuid(),
            Username = "atendente",
            Email = "atendente@rental.com",
            PasswordHash = BCrypt.Net.BCrypt.HashPassword("Atendente@123"),
            FullName = "Atendente Padrão",
            Role = UserRole.Atendente,
            IsActive = true,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        await context.Users.AddRangeAsync(adminUser, attendantUser);

        // Seed Vehicles
        var vehicles = new[]
        {
            new Vehicle
            {
                Id = Guid.NewGuid(),
                Brand = "Toyota",
                Model = "Corolla",
                Year = 2024,
                LicensePlate = "ABC-1234",
                Color = "Prata",
                Type = VehicleType.Sedan,
                DailyRate = 150.00m,
                Status = VehicleStatus.Available,
                Mileage = 5000,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Vehicle
            {
                Id = Guid.NewGuid(),
                Brand = "Honda",
                Model = "Civic",
                Year = 2023,
                LicensePlate = "DEF-5678",
                Color = "Preto",
                Type = VehicleType.Sedan,
                DailyRate = 140.00m,
                Status = VehicleStatus.Available,
                Mileage = 15000,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Vehicle
            {
                Id = Guid.NewGuid(),
                Brand = "Volkswagen",
                Model = "T-Cross",
                Year = 2024,
                LicensePlate = "GHI-9012",
                Color = "Branco",
                Type = VehicleType.SUV,
                DailyRate = 180.00m,
                Status = VehicleStatus.Available,
                Mileage = 3000,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Vehicle
            {
                Id = Guid.NewGuid(),
                Brand = "Chevrolet",
                Model = "Onix",
                Year = 2023,
                LicensePlate = "JKL-3456",
                Color = "Vermelho",
                Type = VehicleType.Hatchback,
                DailyRate = 120.00m,
                Status = VehicleStatus.Available,
                Mileage = 20000,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Vehicle
            {
                Id = Guid.NewGuid(),
                Brand = "Jeep",
                Model = "Compass",
                Year = 2024,
                LicensePlate = "MNO-7890",
                Color = "Cinza",
                Type = VehicleType.SUV,
                DailyRate = 200.00m,
                Status = VehicleStatus.Available,
                Mileage = 2000,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            }
        };

        await context.Vehicles.AddRangeAsync(vehicles);

        // Seed Customers
        var customers = new[]
        {
            new Customer
            {
                Id = Guid.NewGuid(),
                Name = "João Silva",
                Email = "joao.silva@email.com",
                Phone = "(11) 98765-4321",
                DriversLicense = "12345678900",
                Address = "Rua das Flores, 123 - São Paulo, SP",
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Customer
            {
                Id = Guid.NewGuid(),
                Name = "Maria Santos",
                Email = "maria.santos@email.com",
                Phone = "(21) 97654-3210",
                DriversLicense = "98765432100",
                Address = "Av. Atlântica, 456 - Rio de Janeiro, RJ",
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Customer
            {
                Id = Guid.NewGuid(),
                Name = "Pedro Oliveira",
                Email = "pedro.oliveira@email.com",
                Phone = "(31) 96543-2109",
                DriversLicense = "11122233344",
                Address = "Rua dos Minérios, 789 - Belo Horizonte, MG",
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            }
        };

        await context.Customers.AddRangeAsync(customers);

        await context.SaveChangesAsync();
    }
}
