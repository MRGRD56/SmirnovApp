using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SmirnovApp.Context;
using SmirnovApp.Model.DbModels;
using SmirnovApp.Views.Windows;

namespace SmirnovApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        internal const string AppName = "AppName";

        internal new static MainWindow MainWindow => (MainWindow) Current.MainWindow;

        /// <summary>
        /// Заполняет базу данных начальными значениями.
        /// </summary>
        /// <param name="force">Заполняет БД данными, даже если БД уже была создана.</param>
        /// <param name="drop">Удаляет базу данных перед заполнением. БД будет пересоздана. Все внесённые изменения в БД будут потеряны.</param>
        private void FillDatabase(bool force = false, bool drop = false)
        {
            using var db = new AppDbContext();

            if (drop)
            {
                db.Database.EnsureDeleted();
            }

            //Заполняет таблицу начальными данными при первом создании БД или при force == true.
            if (!db.Database.EnsureCreated() && !force) return;

            var users = new List<User>
            {
                new()
                {
                    Login = "1",
                    Password = "1"
                },
                new()
                {
                    Login = "ivanov",
                    Password = "123123"
                }
            };
            db.Users.AddRange(users);

            var positions = new List<Position>
            {
                new()
                {
                    Name = "Первая должность"
                },
                new()
                {
                    Name = "Должность два"
                }
            };
            db.Positions.AddRange(positions);

            var owners = new List<Owner>
            {
                new()
                {
                    LastName = "Иванов",
                    FirstName = "Сергей",
                    Patronymic = "Петрович",
                    BirthDate = DateTime.Parse("1994-11-21"),
                    Phone = "+79123214152",
                    ApplicationDate = DateTime.Now.AddDays(-2)
                },
                new()
                {
                    LastName = "Ефремова",
                    FirstName = "Ольга",
                    Patronymic = "Викторовна",
                    BirthDate = DateTime.Parse("1997-01-17"),
                    Phone = "+79123523625",
                    ApplicationDate = DateTime.Now.AddDays(-14)
                },
                new()
                {
                    LastName = "Хлопунов",
                    FirstName = "Олег",
                    Patronymic = "Николаевич",
                    BirthDate = DateTime.Parse("1985-08-01"),
                    Phone = "+79178721461",
                    ApplicationDate = DateTime.Now.AddDays(-5)
                }
            };
            db.Owners.AddRange(owners);

            var clients = new List<Client>
            {
                new()
                {
                    LastName = "Пшеницын",
                    FirstName = "Данила",
                    Patronymic = "Владимирович",
                    BirthDate = DateTime.Parse("2000-12-08"),
                    ApplicationDate = DateTime.Now.AddDays(-4)
                },
                new()
                {
                    LastName = "Николаев",
                    FirstName = "Сергей",
                    Patronymic = "Сергеевич",
                    BirthDate = DateTime.Parse("2000-04-04"),
                    ApplicationDate = DateTime.Now.AddDays(-1)
                },
                new()
                {
                    LastName = "Шишкина",
                    FirstName = "Ольга",
                    Patronymic = "Сергеевна",
                    BirthDate = DateTime.Parse("1989-07-28"),
                    ApplicationDate = DateTime.Now.AddDays(-40)
                }
            };
            db.Clients.AddRange(clients);

            var employees = new List<Employee>
            {
                new()
                {
                    LastName = "Гришин",
                    FirstName = "Александр",
                    Patronymic = "Иванович",
                    BirthDate = DateTime.Parse("1978-03-08"),
                    Phone = "+73214242936",
                    Position = positions[0],
                    Salary = 100500
                },
                new()
                {
                    LastName = "Максимова",
                    FirstName = "София",
                    Patronymic = "Данииловна",
                    BirthDate = DateTime.Parse("1988-09-21"),
                    Phone = "+793475629534",
                    Position = positions[0],
                    Salary = 86000
                },
                new()
                {
                    LastName = "Соколов",
                    FirstName = "Дмитрий",
                    Patronymic = "Артёмович",
                    BirthDate = DateTime.Parse("1999-12-08"),
                    Phone = "+732142124124",
                    Position = positions[1],
                    Salary = 19000
                }
            };
            db.Employees.AddRange(employees);

            var estateTypes = new List<EstateType>
            {
                new()
                {
                    Name = "Квартира"
                },
                new()
                {
                    Name = "Частный дом"
                },
                new()
                {
                    Name = "Студия"
                }
            };
            db.EstateTypes.AddRange(estateTypes);

            var estates = new List<Estate>
            {
                new()
                {
                    Name = "Кстати, независимые государства",
                    Address = "А также диаграммы связей подвергнуты",
                    Area = 120,
                    Cost = 4_000_000,
                    FloorsCount = 1,
                    Floor = 1,
                    Owner = owners[0],
                    Type = estateTypes[0]
                },
                new()
                {
                    Name = "Учитывая ключевые сценарии поведения",
                    Address = "Современные технологии достигли такого",
                    Area = 80,
                    Cost = 2_200_000,
                    FloorsCount = 20,
                    Floor = 12,
                    Owner = owners[1],
                    Type = estateTypes[1]
                },
                new()
                {
                    Name = "Банальные, но неопровержимые выводы",
                    Address = "Но укрепление и развитие внутренней",
                    Area = 150,
                    Cost = 14_000_000,
                    FloorsCount = 16,
                    Floor = 3,
                    Owner = owners[2],
                    Type = estateTypes[2]
                },
            };
            db.Estates.AddRange(estates);

            var services = new List<Service>
            {
                new()
                {
                    Name = "Задача организации, в особенности",
                    Cost = 12_000
                },
                new()
                {
                    Name = "Но укрепление и развитие",
                    Cost = 6_600
                }
            };
            db.Services.AddRange(services);

            var contracts = new List<Contract>
            {
                new()
                {
                    Name = "В рамках спецификации современных стандартов",
                    Amount = 120_000,
                    Client = clients[0],
                    Employee = employees[0],
                    Estate = estates[0],
                    Service = services[0],
                    Date = DateTime.Parse("2021-03-29"),
                    Status = ContractStatus.ServiceProvided
                },
                new()
                {
                    Name = "Внезапно, интерактивные прототипы неоднозначны",
                    Amount = 1_400_000,
                    Client = clients[1],
                    Employee = employees[1],
                    Estate = estates[1],
                    Service = services[1],
                    Date = DateTime.Parse("2021-04-26"),
                    Status = ContractStatus.NotPerformed
                },
                new()
                {
                    Name = "Значимость этих проблем настолько очевидна",
                    Amount = 800_000,
                    Client = clients[2],
                    Employee = employees[2],
                    Estate = estates[2],
                    Service = services[1],
                    Date = DateTime.Parse("2021-05-11"),
                    Status = ContractStatus.NotPerformed
                }
            };
            db.Contracts.AddRange(contracts);

            db.SaveChanges();
        }

        public App()
        {
            FillDatabase(force: false, drop: false);
        }
    }
}
