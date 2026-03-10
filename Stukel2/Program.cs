using VikingNS;

Viking v1 = new Viking();
v1.ViewH();

Console.WriteLine();

Viking v2 = new Viking( "Ragnar", Global.Status.JARL, 250, Global.Weapon.SWORD, true);
v2.ViewV();
