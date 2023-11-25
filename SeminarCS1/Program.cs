
using SeminarCS1;
using static SeminarCS1.PrintPerson;

FamilyMambers grandMother1 = new() { FullName = "Вождь Мария Андреевна", Age = 50, Gender = Gender.woman };
FamilyMambers grandFather1 = new() { FullName = "Андропов Виктор Юрьевич", Age = 40, Gender = Gender.man };
FamilyMambers grandMother2 = new() { FullName = "Андреева Наташа Николаевна", Age = 50, Gender = Gender.woman };
FamilyMambers grandFather2 = new() { FullName = "Кремль Констонтин Антон", Age = 40, Gender = Gender.man };
grandFather1.Wife = grandMother1;
grandMother1.Husband = grandFather1;
grandFather2.Wife = grandMother2;
grandMother2.Husband = grandFather2;

FamilyMambers father = new() { FullName = "Иванов Иван Викторович", Age = 30 , Gender = Gender.man, Mother = grandMother1, Father = grandFather1 };
FamilyMambers mother = new() { FullName = "Иванова Мария Константиновна", Age = 30, Gender = Gender.woman, Mother = grandMother2, Father =grandFather2 };
father.Wife = mother;
mother.Husband = mother;
grandFather1.Children = new FamilyMambers[] { father };
grandMother1.Children = new FamilyMambers[] { father };
grandFather2.Children = new FamilyMambers[] { mother };
grandMother2.Children = new FamilyMambers[] { mother };

FamilyMambers doughter = new() { FullName = "Дочева Света Ивановна", Age = 20, Gender = Gender.woman, /*Mother = mother,*/ Father = father, };
FamilyMambers son = new() { FullName = "Сидоров Игорь Иванович", Age = 10, Gender = Gender.man, Mother = mother, Father = father };
father.Children = new FamilyMambers[] { doughter, son };
mother.Children = new FamilyMambers[] { doughter, son };

FamilyMambers child1 = new() { FullName = "Петрова Юля Олеговна", Age = 10, Gender = Gender.woman};
FamilyMambers child2 = new() { FullName = "Петрова Вика Олеговна", Age = 10, Gender = Gender.woman };
FamilyMambers child3 = new() { FullName = "Петров Вадим Олегович", Age = 10, Gender = Gender.man };

FamilyMambers mamber5 = new() { FullName = "Петров Олег Валентинович", Age = 20, Gender = Gender.man, Wife = doughter, Children = new FamilyMambers[] { child1, child2, child3 } };
doughter.Husband = mamber5;
doughter.Children = new FamilyMambers[] { child1, child2, child3 };


son.PrintGrandMothers();
doughter.PrintGrandFathers();
doughter.PrintCloseRelative();
doughter.PrintChildren();


