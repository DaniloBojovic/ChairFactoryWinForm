using System;
using System.Collections.Generic;
using System.Data.Entity;
using Entities.Model;

namespace Dal
{
    public class AppDbInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            /*
             * Ova klasa je nova
             */
            var machines = new List<Machine>() // Masina
            {
                new Machine{Id = 0, Name = "Rucni rad"},
                new Machine{Id = 1, Name = "Strug"},
                new Machine{Id = 2, Name = "Cirkular"},
                new Machine{Id = 3, Name = "Univerzalna stolarska masina"},
                new Machine{Id = 4, Name = "Abrihter"}
            };

            /*
             * U ovoj klasi sema je malo promenjena. Operacija rada je sad povezana sa predmetom rada umesto sa tehnoloskim postupkom
             */
            var workOperations = new List<WorkOperation>() // Operacija rada
            {
                new WorkOperation{Id = 1, Name = "Struganje noge stolice", Description = "Struganje elementa", ItemId = 2, TimeNeeded = 2.00, MachineId = 1,Quantity = 4}, //Operacije rada za stolicu
                new WorkOperation{Id = 2, Name = "Secenje ploce sedala", Description = "Secenje po dimenziji", ItemId = 3, TimeNeeded = 3.00, MachineId = 2,Quantity = 1},
                new WorkOperation{Id = 3, Name = "Struganje precage stolice", Description = "Struganje elementa", ItemId = 4, TimeNeeded = 2.00, MachineId = 1,Quantity = 1},
                new WorkOperation{Id = 4, Name = "Struganje ledjnog ojacanja", Description = "Struganje elementa", ItemId = 5, TimeNeeded = 2.00, MachineId = 1,Quantity = 1},
                new WorkOperation{Id = 5, Name = "Busenje rupa na nogama", Description = "Busenje rupa", ItemId = 2, TimeNeeded = 4.00, MachineId = 3,Quantity = 4},
                new WorkOperation{Id = 6, Name = "Busenje rupa na sedistu", Description = "Busenje rupa", ItemId = 3, TimeNeeded = 1.30, MachineId = 3, Quantity = 4},
                new WorkOperation{Id = 7, Name = "Sklapanje stolice", Description = "Sastavljanje stolice", ItemId = 1, TimeNeeded = 3.00,MachineId = 0, Quantity = 1},

                new WorkOperation{Id = 8, Name = "Secenje po meri stranice rama", Description = "Secenje stranica", ItemId = 7, TimeNeeded = 2.00, MachineId = 2, Quantity = 4}, //O.r. za Ogledalo
                new WorkOperation{Id = 9, Name = "Glacanje stranice rama", Description = "Fino glacanje", ItemId = 7, TimeNeeded = 4.00, MachineId = 4,Quantity = 4},
                new WorkOperation{Id = 10, Name = "Busenje rupa na sastavu", Description = "Busenje rupa", ItemId = 7, TimeNeeded = 1.00, MachineId = 3,Quantity = 4},
                new WorkOperation{Id = 11, Name = "Zlebovanje kanala bocne stranice", Description = "Pravljenje zljebova", ItemId = 7, TimeNeeded = 4.00, MachineId = 3,Quantity = 1},
                new WorkOperation{Id = 12, Name = "Umetanje ogledala na osnovnu stranicu", Description = "Umetanje ogledala", ItemId = 8, TimeNeeded = 2.00,Quantity = 1},
                new WorkOperation{Id = 13, Name = "Sklapanje ogledala", Description = "Sastavljanje ogledala", ItemId = 6, TimeNeeded = 4.00, MachineId = 0,Quantity = 1},

                new WorkOperation{Id = 14, Name = "Secenje ploce stola", Description = "Secenje ploce", ItemId = 10, TimeNeeded = 5.00, MachineId = 2,Quantity = 1}, // O.r. za Sto
                new WorkOperation{Id = 15, Name = "Secenje noge stola na meru", Description = "Secenje noge", ItemId = 11, TimeNeeded = 4.00, MachineId = 2,Quantity = 4},
                new WorkOperation{Id = 16, Name = "Busenje ploce", Description = "Busenje ploce", ItemId = 10, TimeNeeded = 2.00, MachineId = 3,Quantity = 1},
                new WorkOperation{Id = 17, Name = "Glacanje noge stola", Description = "Glacanje", ItemId = 11, TimeNeeded = 3.00, MachineId = 4,Quantity = 4},
                new WorkOperation{Id = 18, Name = "Glacanje ploce stola", Description = "Glacanje", ItemId = 10, TimeNeeded = 3.00, MachineId = 4,Quantity = 1},
                new WorkOperation{Id = 19, Name = "Montaza stola", Description = "Sastavljanje stola", ItemId = 9, TimeNeeded = 4.00, MachineId = 0,Quantity = 1},

                new WorkOperation{Id = 20, Name = "Secenje ploce za pozadinu po meri", Description = "Secenje ploce", ItemId = 10, TimeNeeded = 5.00, MachineId = 2,Quantity = 1}, //O.r. za civiluk
                new WorkOperation{Id = 21, Name = "Secenje stranica rama po meri", Description = "Secenje stranica", ItemId = 13, TimeNeeded = 2.00, MachineId = 2,Quantity = 1},
                new WorkOperation{Id = 22, Name = "Zljebovanje bocnih stranica", Description = "Pravljenje zljebova", ItemId = 13, TimeNeeded = 4.00, MachineId = 4,Quantity = 1},
                new WorkOperation{Id = 23, Name = "Montaza bocnih stranica", Description = "Sklapanje stranica na plocu", ItemId = 13, TimeNeeded = 4.00, MachineId = 0,Quantity = 1},
                new WorkOperation{Id = 24, Name = "Montaza metalnih vesalica", Description = "Zavrtanje vesalica", ItemId = 14, TimeNeeded = 5.00, MachineId = 0,Quantity = 1},
                new WorkOperation{Id = 25, Name = "Montaza civiluka", Description = "Finalna montaza civiluka", ItemId = 12, TimeNeeded = 3.00, MachineId = 0,Quantity = 1},

                new WorkOperation{Id = 26, Name = "Struganje noge stolice", Description = "Struganje elementa", ItemId = 16, TimeNeeded = 2.00, MachineId = 1,Quantity = 4}, //Operacije rada za stolicu MODEL 2
                new WorkOperation{Id = 27, Name = "Secenje ploce sedala", Description = "Secenje po dimenziji", ItemId = 17, TimeNeeded = 3.00, MachineId = 2,Quantity = 1},
                new WorkOperation{Id = 28, Name = "Struganje precage stolice", Description = "Struganje elementa", ItemId = 18, TimeNeeded = 2.00, MachineId = 1,Quantity = 1},
                new WorkOperation{Id = 29, Name = "Struganje ledjnog ojacanja", Description = "Struganje elementa", ItemId = 19, TimeNeeded = 2.00, MachineId = 1,Quantity = 1},
                new WorkOperation{Id = 30, Name = "Busenje rupa na nogama", Description = "Busenje rupa", ItemId = 16, TimeNeeded = 4.00, MachineId = 3,Quantity = 4},
                new WorkOperation{Id = 31, Name = "Busenje rupa na sedistu", Description = "Busenje rupa", ItemId = 17, TimeNeeded = 1.30, MachineId = 3, Quantity = 4},
                new WorkOperation{Id = 32, Name = "Sklapanje stolice", Description = "Sastavljanje stolice", ItemId = 15, TimeNeeded = 3.00,MachineId = 0, Quantity = 1},
            };

           

            var items = new List<Item>() // Predmet rada
            {
                new Item {Id = 1, Material = null, Name = "Stolica MORAVA"}, //STOLICA MORAVA
                new Item {Id = 2, Material = "Drvo", Name = "Noga stolice",PartId = 1},
                new Item {Id = 3, Material = "Koza", Name = "Sediste",PartId = 1},
                new Item {Id = 4, Material = "Drvo", Name = "Precaga", PartId = 1},
                new Item {Id = 5, Material = "Drvo", Name = "Ukosnica ledjnog ojacanja", PartId = 1},

                new Item {Id = 6, Material = null, Name = "Ogledalo MODEL 15"}, //OGLEDALO
                new Item {Id = 7, Material = "Drvo", Name = "Stranica rama ogledala", PartId = 6},
                new Item {Id = 8, Material = "Staklo", Name = "Stakleni deo ogledala", PartId = 6},

                new Item {Id = 9, Material = null, Name = "Sto BUKVA"}, //STO
                new Item {Id = 10, Material = "Drvo", Name = "Drvena ploca",PartId = 9}, //Predmet rada i kod civiluka
                new Item {Id = 11, Material = "Drvo", Name = "Noga stola", PartId = 9},

                new Item {Id = 12, Material = null, Name = "Čiviluk MODEL 1"}, //CIVILUK
                new Item {Id = 13, Material = "Drvo", Name = "Stranica rama vesalice", PartId = 12},
                new Item {Id = 14, Material = "Metal", Name = "Vesalica", PartId = 12},

                new Item {Id = 15, Material = null, Name = "Stolica MODEL 2"}, //STOLICA MODEL 2
                new Item {Id = 16, Material = "Drvo", Name = "Noga stolice MODEL 2",PartId = 15},
                new Item {Id = 17, Material = "Koza", Name = "Sediste stolice MODEL 2",PartId = 15},
                new Item {Id = 18, Material = "Drvo", Name = "Precaga stolice MODEL 2", PartId = 15},
                new Item {Id = 19, Material = "Drvo", Name = "Ukosnica ledjnog ojacanja MODEL 2", PartId = 15},

            };
            /*
             * U ovoj klasi dodato je obelezje CreationDate, koje oznacava datum kreiranja narudzbe
             */
            var operationPlans = new List<OperationPlan>() // Operacioni plan
            {
                new OperationPlan{Id = 1, Client = "Simpo",CreationDate = DateTime.Parse("6/6/2018") ,StartDate = DateTime.Parse("6/8/2018"), EndDate = DateTime.Today.AddDays(-1), Deadline = DateTime.Today.AddDays(-2)},
                new OperationPlan{Id = 2, Client = "Forma Ideale", CreationDate = DateTime.Today ,StartDate = DateTime.Today.AddDays(-60), EndDate = DateTime.Today.AddDays(-25), Deadline = DateTime.Today.AddDays(-28)},
                new OperationPlan{Id = 3, Client = "IKEA",CreationDate = DateTime.Today ,StartDate = DateTime.Today.AddDays(-45), EndDate = DateTime.Today.AddDays(-30), Deadline = DateTime.Today.AddDays(-35)},
                new OperationPlan{Id = 4, Client = "Vitorog",CreationDate = DateTime.Today ,StartDate = DateTime.Today.AddDays(-35), EndDate = DateTime.Today.AddDays(-4), Deadline = DateTime.Today.AddDays(-4)},
                new OperationPlan{Id = 5, Client = "IKEA",CreationDate = DateTime.Today ,StartDate = DateTime.Today.AddDays(-1),  Deadline = DateTime.Today.AddDays(30), EndDate = DateTime.Today.AddDays(28)},
                new OperationPlan{Id = 6, Client = "Glorija",CreationDate = DateTime.Today ,StartDate = DateTime.Today.AddDays(2), Deadline = DateTime.Today.AddDays(31), EndDate = DateTime.Today.AddDays(30)}
            };


            var productionPlans = new List<ProductionPlan>() // Proizvodni plan
            {
                new ProductionPlan{Id = 1, ItemId = 1, OperationPlanId = 1, Quantity = 100},
                new ProductionPlan{Id = 2, ItemId = 6, OperationPlanId = 2, Quantity = 200},
                new ProductionPlan{Id = 3, ItemId = 9, OperationPlanId = 3, Quantity = 120},
                new ProductionPlan{Id = 4, ItemId = 12, OperationPlanId = 4, Quantity = 10},
                new ProductionPlan{Id = 5, ItemId = 15, OperationPlanId = 1, Quantity = 50},
                new ProductionPlan{Id = 6, ItemId = 9, OperationPlanId = 1, Quantity = 85},
                new ProductionPlan{Id = 7, ItemId = 1, OperationPlanId = 2, Quantity = 850},
                new ProductionPlan{Id = 8, ItemId = 12, OperationPlanId = 2, Quantity = 12},
                new ProductionPlan{Id = 9, ItemId = 15, OperationPlanId = 2, Quantity = 15},
                new ProductionPlan{Id = 10, ItemId = 12, OperationPlanId = 3, Quantity = 60},
                new ProductionPlan{Id = 11, ItemId = 15, OperationPlanId = 4, Quantity = 200},
                new ProductionPlan{Id = 12, ItemId = 6, OperationPlanId = 4, Quantity = 10},
                new ProductionPlan{Id = 13, ItemId = 1, OperationPlanId = 5, Quantity = 36},
                new ProductionPlan{Id = 14, ItemId = 9, OperationPlanId = 5, Quantity = 17},
                new ProductionPlan{Id = 15, ItemId = 1, OperationPlanId = 6, Quantity = 22},
                new ProductionPlan{Id = 16, ItemId = 12, OperationPlanId = 6, Quantity = 90},
            };

            machines.ForEach(m => context.Machines.Add(m));
            items.ForEach(i => context.Items.Add(i));
            operationPlans.ForEach(p => context.OperationPlans.Add(p));   
            workOperations.ForEach(w => context.WorkOperations.Add(w));
            productionPlans.ForEach(p => context.ProductionPlans.Add(p));

            base.Seed(context);
        }
    }
}