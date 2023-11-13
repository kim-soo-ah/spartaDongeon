using System.Reflection.PortableExecutable;

namespace SpartaDongeon
{
    internal class Program
    {
        private static Character player;
        
        


        static void GameDataSetting()//캐릭터 정보 세팅
        {
            player = new Character("Chad", "전사", 1, 10, 5, 100, 1500);
            
            
        }

        static void GameItemSetting()
        {

            string[] ironAmor = { "무쇠갑옷", "방어력 +5", "무쇠로 만들어져 튼튼한 갑옷입니다." };
            string[] oldKnife = { "낡은 검", "공격력 +2", "쉽게 볼 수 있는 낡은 검 입니다." };
            string[] bigShield = { "짱 큰 방패", "방어력 +10", "모든걸 막을 수 있는 방패입니다." };
            string[] roseKnife = { "장미 칼", "공격력 +7", "매우 날카로워 스치기만 해도 데미지가 큰 칼입니다" };
            Console.WriteLine(ironAmor[0]+ " | " + ironAmor[1] + " | " + ironAmor[2]);
            Console.WriteLine(oldKnife[0] + " | " + oldKnife[1] + " | " + oldKnife[2]);
            Console.WriteLine(bigShield[0] + " | " + bigShield[1] + " | " + bigShield[2]);
            Console.WriteLine(roseKnife[0] + " | " + roseKnife[1] + " | " + roseKnife[2]);
            

            

            
        }




        static void DisplayGameIntro()
        {
            Console.Clear();

            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 전전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");

            int input = CheckValidInput(1, 2);
            switch (input)
            {
                case 1:
                    DisplayMyInfo();
                    break;

                case 2:
                    DisplayInventory();
                    break;
            }

        }   

        static void DisplayMyInfo()
        {
            Console.Clear();

            Console.WriteLine("상태보기");
            Console.WriteLine("캐릭터의 정보를 표시합니다.");
            Console.WriteLine();
            Console.WriteLine($"Lv.{player.Level}");
            Console.WriteLine($"{player.Name}({player.Job})");
            Console.WriteLine($"공격력 :{player.Atk}");
            Console.WriteLine($"방어력 : {player.Def}");
            Console.WriteLine($"체력 : {player.Hp}");
            Console.WriteLine($"Gold : {player.Gold} G");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");

            int input = CheckValidInput(0, 0);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
            }
        }

        static void DisplayInventory()
        {
            Console.Clear();

            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            GameItemSetting();
            Console.WriteLine();
            Console.WriteLine("1. 장착관리");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");

            int input = CheckValidInput(0, 1);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
                case 1:
                    DisplayInventoryManager();
                    break;

            }


        }

        static void DisplayInventoryManager()
        {
            Console.Clear();

            Console.WriteLine("인벤토리 - 장착관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            GameItemSetting();
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");

            
            int input = CheckValidInput(0, 0);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
                

            }


        }

        

        static int CheckValidInput(int min, int max)
        {
            while (true)
            {
                string input = Console.ReadLine();

                bool parseSuccess = int.TryParse(input, out var ret);
                if (parseSuccess)
                {
                    if (ret >= min && ret <= max)
                        return ret;
                }

                Console.WriteLine("잘못된 입력입니다.");
            }
        }


        
        public class Character
        {
            public string Name { get; }
            public string Job { get; }
            public int Level { get; }
            public int Atk { get; }
            public int Def { get; }
            public int Hp { get; }
            public int Gold { get; }

            public Character(string name, string job, int level, int atk, int def, int hp, int gold)
            {
                Name = name;
                Job = job;
                Level = level;
                Atk = atk;
                Def = def;
                Hp = hp;
                Gold = gold;
            }
        }
        static void Main(string[] args)
        {
            GameDataSetting();
            DisplayGameIntro();
            
        }
    }
}