/* 
* Author: Pol Robledillo Ortega
* M03. Programació UF1
* 2/11/2023
* PR1 Joc de Batalla d'Herois VS Monstre. Dissenyar i programar un joc de batalla d'herois vs Monstre 
* seguint el paradigma de la programació imperativa, utilitzant tipus de dades simples i estructures 
* de control condicionals i iteratives.
* 
*/


using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices.ObjectiveC;

namespace GameProject
{
    class RobledilloPolCode
    {
        static void Main()
        {
            int start, attempts = 0, statAttempts = 0, round = 1, action = 0;
            bool maxAttemptsReached = false;
            string attacker, target;
            double totalHeroesHP = 0, damage = 0;
            const int StartFight = 1, EndGame = 2, MaxAttempts = 3, MaxCDSkills = 5;
            const string MsgStart = "1. Iniciar nova batalla \n2. Sortir";
            const string MsgInvalidValue = "Has introduït un valor no vàlid.";
            const string MsgStatAttempts = "Intents restants per aquesta característica: ";
            const string MsgTotalAttempts = "Intents totals restants: ";
            const string MsgStartFight = "Comença el combat! ";
            const string MsgShowRound = "Ronda ";
            const string FirstMsgAttack = " ataca al monstre amb ";
            const string SecondMsgAttack = " d'atac. ";
            const string ThirdMsgAttack = " es defensa i només rep ";
            const string FourthMsgAttack = " de dany. Vida restant de ";
            const string MsgSkillOnCD = "La habilitat està en cooldown. Torns fins que torni a estar disponible: ";
            const string MsgDeath = " ha mort.";
            const string MsgNextRound = "Prem qualsevol tecla per passar a la següent ronda: ";
            const string MsgDefeat = "Tots els Herois han mort. Has perdut.";
            const string MsgVictory = "Has guanyat!!!";
            const string MsgMaxAttemptsReached = "Has esgotat tots els intents.";


            double hpArcher = 0, atkArcher = 0, defArcher = 0, cdArcherSkill = 0, currentHPArcher;                                                    //Variables i constants arquera
            const int MinHPArcher = 1500, MaxHPArcher = 2000, MinAtkArcher = 180, MaxAtkArcher = 300, MinDefArcher = 25, MaxDefArcher = 40;
            bool archerProtect = false;
            const string MsgArcher = "Arquera";
            const string MsgHPArcher = "Introdueix la vida de l'arquera [1500-2000]: ";
            const string MsgAtkArcher = "Introdueix l'atac de l'arquera [180-300]: ";
            const string MsgDefArcher = "Introdueix la defensa de l'arquera [25-40]%: ";
            const string MsgSelectArcherAction = "Arquera \nSelecciona l'acció: \n1. Atacar \n2. Protegir-se (Defensa x2) \n3. Habilitat especial (5 torns de CD): Noqueja el monstre 2 torns";
            const string MsgArcherSkill = "El monstre ha quedat noquejat per als següents 2 torns.";


            double hpBarbarian = 0, atkBarbarian = 0, defBarbarian = 0, cdBarbarianSkill = 0, currentHPBarbarian;                                                    //Variables i constants bàrbar
            int roundsBarbarianSkill = 0;
            bool barbarianProtect = false;
            const int MinHPBarbarian = 3000, MaxHPBarbarian = 3750, MinAtkBarbarian = 150, MaxAtkBarbarian = 250, MinDefBarbarian = 35, MaxDefBarbarian = 45, MaxRoundsBarbarianSkill = 3;
            const string MsgBarbarian = "Bàrbar";
            const string MsgHPBarbarian = "Introdueix la vida del bàrbar [3000-3750]: ";
            const string MsgAtkBarbarian = "Introdueix l'atac del bàrbar [150-250]: ";
            const string MsgDefBarbarian = "Introdueix la defensa del bàrbar [35-45]%: ";
            const string MsgSelectBarbarianAction = "Bàrbar \nSelecciona l'acció: \n1. Atacar \n2. Protegir-se (Defensa x2) \n3. Habilitat especial (5 torns de CD): Augmenta la seva defensa al 100% durant 3 torns";
            const string MsgBarbarianSkill = "La defensa del Bàrbar ha augmentat al 100% durant 2 torns.";


            double hpMage = 0, atkMage = 0, defMage = 0, cdMageSkill = 0, currentHPMage;                                                  //Variables i constants maga
            bool mageProtect = false;
            const int MinHPMage = 1000, MaxHPMage = 1500, MinAtkMage = 300, MaxAtkMage = 350, MinDefMage = 20, MaxDefMage = 35;
            const string MsgMage = "Maga";
            const string MsgHPMage = "Introdueix la vida de la maga [1000-1500]: ";
            const string MsgAtkMage = "Introdueix l'atac de la maga [300-350]: ";
            const string MsgDefMage = "Introdueix la defensa de la maga [20-35]%: ";
            const string MsgSelectMageAction = "Maga \nSelecciona l'acció: \n1. Atacar \n2. Protegir-se (Defensa x2) \n3. Habilitat especial (5 torns de CD): Dispara una bola de foc que fa 3 cops el seu atac";
            const string MsgMageSkill = " llença una bola de foc al monstre, ";


            double hpDruid = 0, atkDruid = 0, defDruid = 0, cdDruidSkill = 0, currentHPDruid;                                                 //Variables i constants druida
            bool druidProtect = false;
            const int MinHPDruid = 2000, MaxHPDruid = 2500, MinAtkDruid = 70, MaxAtkDruid = 120, MinDefDruid = 25, MaxDefDruid = 40, MaxHealing = 500;
            const string MsgDruid = "Druida";
            const string MsgHPDruid = "Introdueix la vida del druida [2000-2500]: ";
            const string MsgAtkDruid = "Introdueix l'atac del druida [70-120]: ";
            const string MsgDefDruid = "Introdueix la defensa del druida [25-40]%: ";
            const string MsgSelectDruidAction = "Druida \nSelecciona l'acció: \n1. Atacar \n2. Protegir-se (Defensa x2) \n3. Habilitat especial (5 torns de CD): Cura 500 de vida a tots els herois vius";
            const string MsgDruidHeal = "El Druida cura 500 de vida a tots els herois vius.";
            const string FirstMsgHPHealed = " ha recuperat ";
            const string SecondMsgHPHealed = " de vida.";


            int monsterStunned = 0;
            double hpMonster = 0, atkMonster = 0, defMonster = 0;                                                                  //Variables i constants monstre
            const int MinHPMonster = 9000, MaxHPMonster = 12000, MinAtkMonster = 250, MaxAtkMonster = 400, MinDefMonster = 20, MaxDefMonster = 30;
            const string MsgMonster = "Monstre";
            const string MsgHPMonster = "Introdueix la vida del monstre [9000-12000]: ";
            const string MsgAtkMonster = "Introdueix l'atac del monstre [250-400]: ";
            const string MsgDefMonster = "Introdueix la defensa del monstre [20-30]%: ";
            const string MsgMonsterAction = "El monstre ataca a tots els herois";
            const string MsgMonsterStunned = "El monstre està noquejat. Torns restants: ";

            do
            {
                if (maxAttemptsReached)
                {
                    Console.WriteLine(MsgMaxAttemptsReached);
                    maxAttemptsReached = false;
                }
                Console.WriteLine(MsgStart);
                start = Convert.ToInt32(Console.ReadLine());
                attempts++;
                if (start == StartFight)
                {
                    attempts = 0;
                    Console.WriteLine();
                    Console.WriteLine(MsgArcher);
                    Console.WriteLine();
                    for (int i = 0; i < 3; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                Console.Write(MsgHPArcher);
                                hpArcher = Convert.ToDouble(Console.ReadLine());
                                if ((hpArcher < MinHPArcher) || (hpArcher > MaxHPArcher))           //Selecció vida arquera
                                {
                                    Console.WriteLine(MsgInvalidValue);
                                    Console.WriteLine();
                                    statAttempts++;
                                    if (statAttempts != MaxAttempts)
                                    {
                                        i--;
                                        Console.WriteLine(MsgStatAttempts + (MaxAttempts - statAttempts));
                                        Console.WriteLine();
                                    } else
                                    {
                                        attempts++;
                                        if (attempts != MaxAttempts)
                                        {
                                            i = -1;
                                            statAttempts = 0;
                                            Console.WriteLine(MsgTotalAttempts + (MaxAttempts - attempts));
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            i = 3;
                                        }
                                    }
                                }
                                break;

                            case 1:
                                Console.Write(MsgAtkArcher);
                                atkArcher = Convert.ToDouble(Console.ReadLine());
                                if ((atkArcher < MinAtkArcher) || (atkArcher > MaxAtkArcher))           //Selecció atac arquera
                                {
                                    Console.WriteLine(MsgInvalidValue);
                                    Console.WriteLine();
                                    statAttempts++;
                                    if (statAttempts != MaxAttempts)
                                    {
                                        i--;
                                        Console.WriteLine(MsgStatAttempts + (MaxAttempts - statAttempts));
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        attempts++;
                                        if (attempts != MaxAttempts)
                                        {
                                            i = -1;
                                            statAttempts = 0;
                                            Console.WriteLine(MsgTotalAttempts + (MaxAttempts - attempts));
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            i = 3;
                                        }
                                    }
                                }
                                break;
                            case 2:
                                Console.Write(MsgDefArcher);
                                defArcher = Convert.ToDouble(Console.ReadLine());
                                if ((defArcher < MinDefArcher) ||  (defArcher > MaxDefArcher))           //Selecció defensa arquera
                                {
                                    Console.WriteLine(MsgInvalidValue);
                                    Console.WriteLine();
                                    statAttempts++;
                                    if (statAttempts != MaxAttempts)
                                    {
                                        i--;
                                        Console.WriteLine(MsgStatAttempts + (MaxAttempts - statAttempts));
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        attempts++;
                                        if (attempts != MaxAttempts)
                                        {
                                            i = -1;
                                            statAttempts = 0;
                                            Console.WriteLine(MsgTotalAttempts + (MaxAttempts - attempts));
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            i = 3;
                                        }
                                    }
                                }
                                break;
                        }
                    }
                    if (attempts != MaxAttempts)
                    {
                        Console.WriteLine();
                        Console.WriteLine(MsgBarbarian);
                        attempts = 0;
                        for (int i = 0; i < 3; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    Console.Write(MsgHPBarbarian);
                                    hpBarbarian = Convert.ToDouble(Console.ReadLine());
                                    if ((hpBarbarian < MinHPBarbarian) || (hpBarbarian > MaxHPBarbarian))           //Selecció vida bàrbar
                                    {
                                        Console.WriteLine(MsgInvalidValue);
                                        Console.WriteLine();
                                        statAttempts++;
                                        if (statAttempts != MaxAttempts)
                                        {
                                            i--;
                                            Console.WriteLine(MsgStatAttempts + (MaxAttempts - statAttempts));
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            attempts++;
                                            if (attempts != MaxAttempts)
                                            {
                                                i = -1;
                                                statAttempts = 0;
                                                Console.WriteLine(MsgTotalAttempts + (MaxAttempts - attempts));
                                                Console.WriteLine();
                                            }
                                            else
                                            {
                                                i = 3;
                                            }
                                        }
                                    }
                                    break;

                                case 1:
                                    Console.Write(MsgAtkBarbarian);
                                    atkBarbarian = Convert.ToDouble(Console.ReadLine());
                                    if ((atkBarbarian < MinAtkBarbarian) || (atkBarbarian > MaxAtkBarbarian))           //Selecció atac bàrbar
                                    {
                                        Console.WriteLine(MsgInvalidValue);
                                        Console.WriteLine();
                                        statAttempts++;
                                        if (statAttempts != MaxAttempts)
                                        {
                                            i--;
                                            Console.WriteLine(MsgStatAttempts + (MaxAttempts - statAttempts));
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            attempts++;
                                            if (attempts != MaxAttempts)
                                            {
                                                i = -1;
                                                statAttempts = 0;
                                                Console.WriteLine(MsgTotalAttempts + (MaxAttempts - attempts));
                                                Console.WriteLine();
                                            }
                                            else
                                            {
                                                i = 3;
                                            }
                                        }
                                    }
                                    break;
                                case 2:
                                    Console.Write(MsgDefBarbarian);
                                    defBarbarian = Convert.ToDouble(Console.ReadLine());
                                    if ((defBarbarian < MinDefBarbarian) || (defBarbarian > MaxDefBarbarian))           //Selecció defensa bàrbar
                                    {
                                        Console.WriteLine(MsgInvalidValue);
                                        Console.WriteLine();
                                        statAttempts++;
                                        if (statAttempts != MaxAttempts)
                                        {
                                            i--;
                                            Console.WriteLine(MsgStatAttempts + (MaxAttempts - statAttempts));
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            attempts++;
                                            if (attempts != MaxAttempts)
                                            {
                                                i = -1;
                                                statAttempts = 0;
                                                Console.WriteLine(MsgTotalAttempts + (MaxAttempts - attempts));
                                                Console.WriteLine();
                                            }
                                            else
                                            {
                                                i = 3;
                                            }
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                    if (attempts != MaxAttempts)
                    {
                        Console.WriteLine();
                        Console.WriteLine(MsgMage);
                        attempts = 0;
                        for (int i = 0; i < 3; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    Console.Write(MsgHPMage);
                                    hpMage = Convert.ToDouble(Console.ReadLine());
                                    if ((hpMage < MinHPMage) || (hpMage > MaxHPMage))           //Selecció vida maga
                                    {
                                        Console.WriteLine(MsgInvalidValue);
                                        statAttempts++;
                                        if (statAttempts != MaxAttempts)
                                        {
                                            i--;
                                            Console.WriteLine(MsgStatAttempts + (MaxAttempts - statAttempts));
                                        }
                                        else
                                        {
                                            attempts++;
                                            if (attempts != MaxAttempts)
                                            {
                                                i = -1;
                                                statAttempts = 0;
                                                Console.WriteLine(MsgTotalAttempts + (MaxAttempts - attempts));
                                            }
                                            else
                                            {
                                                i = 3;
                                            }
                                        }
                                    }
                                    break;

                                case 1:
                                    Console.Write(MsgAtkMage);
                                    atkMage = Convert.ToDouble(Console.ReadLine());
                                    if ((atkMage < MinAtkMage) || (atkMage > MaxAtkMage))           //Selecció atac maga
                                    {
                                        Console.WriteLine(MsgInvalidValue);
                                        statAttempts++;
                                        if (statAttempts != MaxAttempts)
                                        {
                                            i--;
                                            Console.WriteLine(MsgStatAttempts + (MaxAttempts - statAttempts));
                                        }
                                        else
                                        {
                                            attempts++;
                                            if (attempts != MaxAttempts)
                                            {
                                                i = -1;
                                                statAttempts = 0;
                                                Console.WriteLine(MsgTotalAttempts + (MaxAttempts - attempts));
                                            }
                                            else
                                            {
                                                i = 3;
                                            }
                                        }
                                    }
                                    break;
                                case 2:
                                    Console.Write(MsgDefMage);
                                    defMage = Convert.ToDouble(Console.ReadLine());
                                    if ((defMage < MinDefMage) || (defMage > MaxDefMage))           //Selecció defensa maga
                                    {
                                        Console.WriteLine(MsgInvalidValue);
                                        statAttempts++;
                                        if (statAttempts != MaxAttempts)
                                        {
                                            i--;
                                            Console.WriteLine(MsgStatAttempts + (MaxAttempts - statAttempts));
                                        }
                                        else
                                        {
                                            attempts++;
                                            if (attempts != MaxAttempts)
                                            {
                                                i = -1;
                                                statAttempts = 0;
                                                Console.WriteLine(MsgTotalAttempts + (MaxAttempts - attempts));
                                            }
                                            else
                                            {
                                                i = 3;
                                            }
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                    if (attempts != MaxAttempts)
                    {
                        Console.WriteLine();
                        Console.WriteLine(MsgDruid);
                        attempts = 0;
                        for (int i = 0; i < 3; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    Console.Write(MsgHPDruid);
                                    hpDruid = Convert.ToDouble(Console.ReadLine());
                                    if ((hpDruid < MinHPDruid) || (hpDruid > MaxHPDruid))           //Selecció vida druida
                                    {
                                        Console.WriteLine(MsgInvalidValue);
                                        statAttempts++;
                                        if (statAttempts != MaxAttempts)
                                        {
                                            i--;
                                            Console.WriteLine(MsgStatAttempts + (MaxAttempts - statAttempts));
                                        }
                                        else
                                        {
                                            attempts++;
                                            if (attempts != MaxAttempts)
                                            {
                                                i = -1;
                                                statAttempts = 0;
                                                Console.WriteLine(MsgTotalAttempts + (MaxAttempts - attempts));
                                            }
                                            else
                                            {
                                                i = 3;
                                            }
                                        }
                                    }
                                    break;

                                case 1:
                                    Console.Write(MsgAtkDruid);
                                    atkDruid = Convert.ToDouble(Console.ReadLine());
                                    if ((atkDruid < MinAtkDruid) || (atkDruid > MaxAtkDruid))           //Selecció atac druida
                                    {
                                        Console.WriteLine(MsgInvalidValue);
                                        statAttempts++;
                                        if (statAttempts != MaxAttempts)
                                        {
                                            i--;
                                            Console.WriteLine(MsgStatAttempts + (MaxAttempts - statAttempts));
                                        }
                                        else
                                        {
                                            attempts++;
                                            if (attempts != MaxAttempts)
                                            {
                                                i = -1;
                                                statAttempts = 0;
                                                Console.WriteLine(MsgTotalAttempts + (MaxAttempts - attempts));
                                            }
                                            else
                                            {
                                                i = 3;
                                            }
                                        }
                                    }
                                    break;
                                case 2:
                                    Console.Write(MsgDefDruid);
                                    defDruid = Convert.ToDouble(Console.ReadLine());
                                    if ((defDruid < MinDefDruid) || (defDruid > MaxDefDruid))           //Selecció defensa druida
                                    {
                                        Console.WriteLine(MsgInvalidValue);
                                        statAttempts++;
                                        if (statAttempts != MaxAttempts)
                                        {
                                            i--;
                                            Console.WriteLine(MsgStatAttempts + (MaxAttempts - statAttempts));
                                        }
                                        else
                                        {
                                            attempts++;
                                            if (attempts != MaxAttempts)
                                            {
                                                i = -1;
                                                statAttempts = 0;
                                                Console.WriteLine(MsgTotalAttempts + (MaxAttempts - attempts));
                                            }
                                            else
                                            {
                                                i = 3;
                                            }
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                    if (attempts != MaxAttempts)
                    {
                        Console.WriteLine();
                        Console.WriteLine(MsgMonster);
                        attempts = 0;
                        for (int i = 0; i < 3; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    Console.Write(MsgHPMonster);
                                    hpMonster = Convert.ToDouble(Console.ReadLine());
                                    if ((hpMonster < MinHPMonster) || (hpMonster > MaxHPMonster))           //Selecció vida monstre
                                    {
                                        Console.WriteLine(MsgInvalidValue);
                                        statAttempts++;
                                        if (statAttempts != MaxAttempts)
                                        {
                                            i--;
                                            Console.WriteLine(MsgStatAttempts + (MaxAttempts - statAttempts));
                                        }
                                        else
                                        {
                                            attempts++;
                                            if (attempts != MaxAttempts)
                                            {
                                                i = -1;
                                                statAttempts = 0;
                                                Console.WriteLine(MsgTotalAttempts + (MaxAttempts - attempts));
                                            }
                                            else
                                            {
                                                i = 3;
                                            }
                                        }
                                    }
                                    break;

                                case 1:
                                    Console.Write(MsgAtkMonster);
                                    atkMonster = Convert.ToDouble(Console.ReadLine());
                                    if ((atkMonster < MinAtkMonster) || (atkMonster > MaxAtkMonster))           //Selecció atac monstre
                                    {
                                        Console.WriteLine(MsgInvalidValue);
                                        statAttempts++;
                                        if (statAttempts != MaxAttempts)
                                        {
                                            i--;
                                            Console.WriteLine(MsgStatAttempts + (MaxAttempts - statAttempts));
                                        }
                                        else
                                        {
                                            attempts++;
                                            if (attempts != MaxAttempts)
                                            {
                                                i = -1;
                                                statAttempts = 0;
                                                Console.WriteLine(MsgTotalAttempts + (MaxAttempts - attempts));
                                            }
                                            else
                                            {
                                                i = 3;
                                            }
                                        }
                                    }
                                    break;
                                case 2:
                                    Console.Write(MsgDefMonster);
                                    defMonster = Convert.ToDouble(Console.ReadLine());
                                    if ((defMonster < MinDefMonster) || (defMonster > MaxDefMonster))           //Selecció defensa monstre
                                    {
                                        Console.WriteLine(MsgInvalidValue);
                                        statAttempts++;
                                        if (statAttempts != MaxAttempts)
                                        {
                                            i--;
                                            Console.WriteLine(MsgStatAttempts + (MaxAttempts - statAttempts));
                                        }
                                        else
                                        {
                                            attempts++;
                                            if (attempts != MaxAttempts)
                                            {
                                                i = -1;
                                                statAttempts = 0;
                                                Console.WriteLine(MsgTotalAttempts + (MaxAttempts - attempts));
                                            }
                                            else
                                            {
                                                i = 3;
                                            }
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                    Console.Clear();
                    if (attempts != MaxAttempts)
                    {
                        currentHPArcher = hpArcher;
                        currentHPBarbarian = hpBarbarian;
                        currentHPMage = hpMage;
                        currentHPDruid = hpDruid;
                        totalHeroesHP = currentHPArcher + currentHPBarbarian + currentHPMage + currentHPDruid;
                        attempts = 0;
                        Console.WriteLine(MsgStartFight);                                                       //Inici combat
                        do
                        {
                            Console.WriteLine(MsgShowRound + round);
                            Console.WriteLine();
                            Console.WriteLine(MsgArcher + ": " + currentHPArcher.ToString("0.00") + "   /   " + MsgBarbarian + ": " + currentHPBarbarian.ToString("0.00") + "   /   " + MsgMage + ": " + currentHPMage.ToString("0.00") + "   /   " + MsgDruid + ": " + currentHPDruid.ToString("0.00") + "   /   " + MsgMonster + ": " + hpMonster.ToString("0.00"));
                            Console.WriteLine();

                            if ((currentHPArcher > 0) && (hpMonster > 0))
                            {
                                attempts = 0;
                                action = 0;
                                while ((attempts < MaxAttempts) && ((action < 1) || (action > 3)))                  //Acció arquera
                                {
                                    Console.WriteLine(MsgSelectArcherAction);
                                    action = Convert.ToInt32(Console.ReadLine());
                                    if ((cdArcherSkill > 0) && (action == 3))
                                    {
                                        Console.WriteLine(MsgSkillOnCD + cdArcherSkill + ". " + MsgTotalAttempts + attempts);
                                        action = 0;
                                    } else if ((action < 1) || (action > 3))
                                    {
                                        Console.WriteLine(MsgInvalidValue + MsgTotalAttempts + attempts);
                                    }
                                    attempts++;
                                }
                                attacker = MsgArcher;
                                target = MsgMonster;
                                switch (action)
                                {
                                    case 1:
                                        damage = atkArcher - (atkArcher * (defMonster / 100));
                                        hpMonster -= damage;
                                        Console.WriteLine(attacker + FirstMsgAttack + atkArcher + SecondMsgAttack + target + ThirdMsgAttack + damage.ToString("0.00") + FourthMsgAttack + target + " " + (hpMonster <= 0 ? 0 : hpMonster.ToString("0.00")));
                                        break;
                                    case 2:
                                        archerProtect = true;
                                        break;
                                    case 3:
                                        Console.WriteLine(MsgArcherSkill);
                                        cdArcherSkill = MaxCDSkills;
                                        monsterStunned = 2;
                                        break;
                                }
                            }
                            Console.WriteLine();

                            if ((attempts < MaxAttempts) && (currentHPBarbarian > 0) && (hpMonster > 0))
                            {
                                attempts = 0;
                                action = 0;
                                while ((attempts < MaxAttempts) && ((action < 1) || (action > 3)))                  //Acció bàrbar
                                {
                                    Console.WriteLine(MsgSelectBarbarianAction);
                                    action = Convert.ToInt32(Console.ReadLine());
                                    if ((cdBarbarianSkill > 0) && (action == 3))
                                    {
                                        Console.WriteLine(MsgSkillOnCD + cdBarbarianSkill + ". " + MsgTotalAttempts + attempts);
                                        action = 0;
                                    } else if ((action < 1) || (action > 3))
                                    {
                                        Console.WriteLine(MsgInvalidValue + MsgTotalAttempts + attempts);
                                    }
                                    attempts++;
                                }
                                attacker = MsgBarbarian;
                                target = MsgMonster;
                                switch (action)
                                {
                                    case 1:
                                        damage = atkBarbarian - (atkBarbarian * (defMonster / 100));
                                        hpMonster -= damage;
                                        Console.WriteLine(attacker + FirstMsgAttack + atkArcher + SecondMsgAttack + target + ThirdMsgAttack + damage.ToString("0.00") + FourthMsgAttack + target + " " + (hpMonster <= 0 ? 0 : hpMonster.ToString("0.00")));
                                        break;
                                    case 2:
                                        barbarianProtect = true;
                                        break;
                                    case 3:
                                        Console.WriteLine(MsgBarbarianSkill);
                                        cdBarbarianSkill = MaxCDSkills;
                                        roundsBarbarianSkill = MaxRoundsBarbarianSkill;
                                        break;
                                }
                            }
                            Console.WriteLine();

                            if ((attempts < MaxAttempts) && (currentHPMage > 0) && (hpMonster > 0))
                            {
                                attempts = 0;
                                action = 0;
                                while ((attempts < MaxAttempts) && ((action < 1) || (action > 3)))                  //Acció maga
                                {
                                    Console.WriteLine(MsgSelectMageAction);
                                    action = Convert.ToInt32(Console.ReadLine());
                                    if ((cdMageSkill > 0) && (action == 3))
                                    {
                                        Console.WriteLine(MsgSkillOnCD + cdMageSkill + ". " + MsgTotalAttempts + attempts);
                                        action = 0;
                                    }else if ((action < 1) || (action > 3))
                                    {
                                        Console.WriteLine(MsgInvalidValue + MsgTotalAttempts + attempts);
                                    }
                                    attempts++;
                                }
                                attacker = MsgMage;
                                target = MsgMonster;
                                switch (action)
                                {
                                    case 1:
                                        damage = atkMage - (atkMage * (defMonster / 100));
                                        hpMonster -= damage;
                                        Console.WriteLine(attacker + FirstMsgAttack + atkMage + SecondMsgAttack + target + ThirdMsgAttack + damage.ToString("0.00") + FourthMsgAttack + target + " " + (hpMonster <= 0 ? 0 : hpMonster.ToString("0.00")));
                                        break;
                                    case 2:
                                        mageProtect = true;
                                        break;
                                    case 3:
                                        cdMageSkill = MaxCDSkills;
                                        damage = (atkMage * 3) - ((atkMage * 3) * (defMonster / 100));
                                        hpMonster -= damage;
                                        Console.WriteLine(attacker + MsgMageSkill + FirstMsgAttack + (atkMage * 3) + SecondMsgAttack + target + ThirdMsgAttack + damage.ToString("0.00") + FourthMsgAttack + target + " " + (hpMonster <= 0 ? 0 : hpMonster.ToString("0.00")));
                                        break;
                                }
                            }
                            Console.WriteLine();

                            if ((attempts < MaxAttempts) && (currentHPDruid > 0) && (hpMonster > 0))
                            {
                                attempts = 0;
                                action = 0;
                                while ((attempts < MaxAttempts) && ((action < 1) || (action > 3)))                  //Acció druida
                                {
                                    Console.WriteLine(MsgSelectDruidAction);
                                    action = Convert.ToInt32(Console.ReadLine());
                                    if ((cdDruidSkill > 0) && (action == 3))
                                    {
                                        Console.WriteLine(MsgSkillOnCD + cdDruidSkill + ". " + MsgTotalAttempts + attempts);
                                        action = 0;
                                    } else if ((action < 1) || (action > 3))
                                    {
                                        Console.WriteLine(MsgInvalidValue + MsgTotalAttempts + attempts);
                                    }
                                    attempts++;
                                }
                                attacker = MsgDruid;
                                target = MsgMonster;
                                switch (action)
                                {
                                    case 1:
                                        damage = atkDruid - (atkDruid * (defMonster / 100));
                                        hpMonster -= damage;
                                        Console.WriteLine(attacker + FirstMsgAttack + atkDruid + SecondMsgAttack + target + ThirdMsgAttack + damage.ToString("0.00") + FourthMsgAttack + target + " " + (hpMonster <= 0 ? 0 : hpMonster.ToString("0.00")));
                                        break;
                                    case 2:
                                        druidProtect = true;
                                        break;
                                    case 3:
                                        cdDruidSkill = MaxCDSkills;
                                        Console.WriteLine(MsgDruidHeal);
                                        if (currentHPArcher > 0)
                                        {
                                            if ((hpArcher - currentHPArcher) < MaxHealing)
                                            {
                                                Console.WriteLine(MsgArcher + FirstMsgHPHealed + (hpArcher - currentHPArcher) + SecondMsgHPHealed);
                                                currentHPArcher = hpArcher;
                                            }
                                            else
                                            {
                                                currentHPArcher += MaxHealing;
                                                Console.WriteLine(MsgArcher + FirstMsgHPHealed + MaxHealing + SecondMsgHPHealed);
                                            }
                                        }
                                        if (currentHPBarbarian > 0)
                                        {
                                            if ((hpBarbarian - currentHPBarbarian) < MaxHealing)
                                            {
                                                Console.WriteLine(MsgBarbarian + FirstMsgHPHealed + (hpBarbarian - currentHPBarbarian) + SecondMsgHPHealed);
                                                currentHPBarbarian = hpBarbarian;
                                            }
                                            else
                                            {
                                                currentHPBarbarian += MaxHealing;
                                                Console.WriteLine(MsgBarbarian + FirstMsgHPHealed + MaxHealing + SecondMsgHPHealed);
                                            }
                                        }
                                        if (currentHPMage > 0)
                                        {
                                            if ((hpMage - currentHPMage) < MaxHealing)
                                            {
                                                Console.WriteLine(MsgMage + FirstMsgHPHealed + (hpMage - currentHPMage) + SecondMsgHPHealed);
                                                currentHPMage = hpMage;
                                            }
                                            else
                                            {
                                                currentHPMage += MaxHealing;
                                                Console.WriteLine(MsgMage + FirstMsgHPHealed + MaxHealing + SecondMsgHPHealed);
                                            }
                                        }
                                        if (currentHPDruid > 0)
                                        {
                                            if ((hpDruid - currentHPDruid) < MaxHealing)
                                            {
                                                Console.WriteLine(MsgDruid + FirstMsgHPHealed + (hpDruid - currentHPDruid) + SecondMsgHPHealed);
                                                currentHPDruid = hpDruid;
                                            }
                                            else
                                            {
                                                currentHPDruid += MaxHealing;
                                                Console.WriteLine(MsgDruid + FirstMsgHPHealed + MaxHealing + SecondMsgHPHealed);
                                            }
                                        }
                                        break;
                                }
                            }
                            Console.WriteLine();

                            if ((attempts < MaxAttempts) && (monsterStunned == 0) && (hpMonster > 0))                  //Acció monstre
                            {
                                Console.WriteLine(MsgMonsterAction);
                                if (currentHPArcher > 0)
                                {
                                    attacker = MsgMonster;
                                    target = MsgArcher;
                                    if (archerProtect)
                                    {
                                        damage = atkMonster - (atkMonster * ((defArcher * 2) / 100));
                                        currentHPArcher -= damage;
                                        Console.WriteLine(attacker + FirstMsgAttack + atkMonster + SecondMsgAttack + target + ThirdMsgAttack + damage.ToString("0.00") + FourthMsgAttack + target + " " + (currentHPArcher <= 0 ? 0 : currentHPArcher.ToString("0.00")));
                                    }else
                                    {
                                        damage = atkMonster - (atkMonster * (defArcher / 100));
                                        currentHPArcher -= damage;
                                        Console.WriteLine(attacker + FirstMsgAttack + atkMonster + SecondMsgAttack + target + ThirdMsgAttack + damage.ToString("0.00") + FourthMsgAttack + target + " " + (currentHPArcher <= 0 ? 0 : currentHPArcher.ToString("0.00")));
                                    }
                                    if (currentHPArcher <= 0)
                                    {
                                        currentHPArcher = 0;
                                        Console.WriteLine(MsgArcher + MsgDeath);
                                    }
                                }
                                if (currentHPBarbarian > 0)
                                {
                                    attacker = MsgMonster;
                                    target = MsgBarbarian;
                                    if (roundsBarbarianSkill > 0)
                                    {
                                        damage = atkMonster - (atkMonster * (100 / 100));
                                        currentHPBarbarian -= damage;
                                        Console.WriteLine(attacker + FirstMsgAttack + atkMonster + SecondMsgAttack + target + ThirdMsgAttack + damage.ToString("0.00") + FourthMsgAttack + target + " " + (currentHPBarbarian <= 0 ? 0 : currentHPBarbarian.ToString("0.00")));
                                    }else if (barbarianProtect)
                                    {
                                        damage = atkMonster - (atkMonster * ((defBarbarian * 2) / 100));
                                        currentHPBarbarian -= damage;
                                        Console.WriteLine(attacker + FirstMsgAttack + atkMonster + SecondMsgAttack + target + ThirdMsgAttack + damage.ToString("0.00") + FourthMsgAttack + target + " " + (currentHPBarbarian <= 0 ? 0 : currentHPBarbarian.ToString("0.00")));
                                    }
                                    else
                                    {
                                        damage = atkMonster - (atkMonster * (defBarbarian / 100));
                                        currentHPBarbarian -= damage;
                                        Console.WriteLine(attacker + FirstMsgAttack + atkMonster + SecondMsgAttack + target + ThirdMsgAttack + damage.ToString("0.00") + FourthMsgAttack + target + " " + (currentHPBarbarian <= 0 ? 0 : currentHPBarbarian.ToString("0.00")));
                                    }
                                    if (currentHPBarbarian <= 0)
                                    {
                                        currentHPBarbarian = 0;
                                        Console.WriteLine(MsgBarbarian + MsgDeath);
                                    }
                                }
                                if (currentHPMage > 0)
                                {
                                    attacker = MsgMonster;
                                    target = MsgMage;
                                    if (mageProtect)
                                    {
                                        damage = atkMonster - (atkMonster * ((defMage * 2) / 100));
                                        currentHPMage -= damage;
                                        Console.WriteLine(attacker + FirstMsgAttack + atkMonster + SecondMsgAttack + target + ThirdMsgAttack + damage.ToString("0.00") + FourthMsgAttack + target + " " + (currentHPMage <= 0 ? 0 : currentHPMage.ToString("0.00")));
                                    }
                                    else
                                    {
                                        damage = atkMonster - (atkMonster * (defMage / 100));
                                        currentHPMage -= damage;
                                        Console.WriteLine(attacker + FirstMsgAttack + atkMonster + SecondMsgAttack + target + ThirdMsgAttack + damage.ToString("0.00") + FourthMsgAttack + target + " " + (currentHPMage <= 0 ? 0 : currentHPMage.ToString("0.00")));
                                    }
                                    if (currentHPMage <= 0)
                                    {
                                        currentHPMage = 0;
                                        Console.WriteLine(MsgMage + MsgDeath);
                                    }
                                }
                                if (currentHPDruid > 0)
                                {
                                    attacker = MsgMonster;
                                    target = MsgDruid;
                                    if (druidProtect)
                                    {
                                        damage = atkMonster - (atkMonster * ((defDruid * 2) / 100));
                                        currentHPDruid -= damage;
                                        Console.WriteLine(attacker + FirstMsgAttack + atkMonster + SecondMsgAttack + target + ThirdMsgAttack + damage.ToString("0.00") + FourthMsgAttack + target + " " + (currentHPDruid <= 0 ? 0 : currentHPDruid.ToString("0.00")));
                                    }
                                    else
                                    {
                                        damage = atkMonster - (atkMonster * (defDruid / 100));
                                        currentHPDruid -= damage;
                                        Console.WriteLine(attacker + FirstMsgAttack + atkMonster + SecondMsgAttack + target + ThirdMsgAttack + damage.ToString("0.00") + FourthMsgAttack + target + " " + (currentHPDruid <= 0 ? 0 : currentHPDruid.ToString("0.00")));
                                    }
                                    if (currentHPDruid <= 0)
                                    {
                                        currentHPDruid = 0;
                                        Console.WriteLine(MsgDruid + MsgDeath);
                                    }
                                }
                            }else if (monsterStunned > 0)
                            {
                                Console.WriteLine(MsgMonsterStunned + (monsterStunned - 1));
                            }
                            
                            if (hpMonster <= 0)
                            {
                                Console.WriteLine(MsgMonster + MsgDeath + MsgVictory);
                                Console.ReadKey();
                                Console.Clear();
                            }else if (totalHeroesHP <= 0)
                            {
                                Console.WriteLine(MsgDefeat);
                                Console.ReadKey();
                                Console.Clear();
                            } else
                            {
                                Console.WriteLine(MsgNextRound);
                                Console.ReadKey();
                                Console.Clear();
                            }

                            if (cdArcherSkill > 0)
                            {
                                cdArcherSkill--;
                            }
                            if (cdBarbarianSkill > 0)
                            {
                                cdBarbarianSkill--;
                            }
                            if (roundsBarbarianSkill > 0)
                            {
                                roundsBarbarianSkill--;
                            }
                            if (cdMageSkill > 0)
                            {
                                cdMageSkill--;
                            }
                            if (cdDruidSkill > 0)
                            {
                                cdDruidSkill--;
                            }
                            if (monsterStunned > 0)
                            {
                                monsterStunned--;
                            }
                            totalHeroesHP = currentHPArcher + currentHPBarbarian + currentHPMage + currentHPDruid;
                            round++;
                        } while (((hpMonster > 0) && (totalHeroesHP > 0)) && (attempts < MaxAttempts));
                    }
                    if (attempts == MaxAttempts)
                    {
                        maxAttemptsReached = true;
                    }
                    attempts = 0;
                }
            } while ((start != EndGame) && (attempts < MaxAttempts));
        }
    }
}