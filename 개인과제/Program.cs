﻿using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
        Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");

        Console.WriteLine();

        Console.WriteLine("1. 상태 보기");
        Console.WriteLine("2. 인벤토리");
        Console.WriteLine("3. 상점");

        Console.Write("원하시는 행동을 입력해주세요.");
        string job = Console.ReadLine();

        switch (job)
        {
            case "1":
                Console.WriteLine("상태 보기");
                Console.WriteLine("캐릭터의 정보가 표시됩니다.");

                Console.WriteLine("Lv. 01");
                Console.WriteLine("전사 ");
                Console.WriteLine("공격력 : 10 ");
                Console.WriteLine("방어력 : 5 ");
                Console.WriteLine("체력 : 100 ");
                Console.WriteLine("Gold : 1500G ");

                Console.WriteLine("0. 나가기 ");

                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.WriteLine(">>");
                break;
            case "2":
                Console.WriteLine("인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");

                Console.WriteLine("1. 장착 관리 ");
                Console.WriteLine("0. 나가기");

                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.WriteLine(">>");
                break;
            case "3":
                Console.WriteLine("상점");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");

                Console.WriteLine("[보유 골드]");
                Console.WriteLine("800 G");

                Console.WriteLine("[아이템 목록]");
                Console.WriteLine("- 수련자 갑옷    | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.             |  1000 G");
                Console.WriteLine("- 무쇠갑옷      | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.           |  구매완료");
                Console.WriteLine("- 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|  3500 G");
                Console.WriteLine("- 낡은 검      | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.            |  600 G");
                Console.WriteLine("- 청동 도끼     | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.        |  1500 G");
                Console.WriteLine("- 스파르타의 창  | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다. |  구매완료");

                Console.WriteLine("1. 아이템 구매");
                Console.WriteLine("0. 나가기");

                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.WriteLine(">>");
                break;
            default:
                Console.WriteLine("잘못된 입력입니다.");
                break;

        }

    }

        class Person
    {
        public string Name;
        public int Lv;

        public void PrintInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Lv: " + Lv);

        }
    }
}