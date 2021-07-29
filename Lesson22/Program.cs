using System;

namespace Lesson22
{
    class Player
    {
        public string name;
        public int hp;
        public int atk;
        public int dfd;
        public float dodgeRate;
        public Player(string name, int hp, int atk, int dfd, float dodgeRate)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
            this.dfd = dfd;
            this.dodgeRate = dodgeRate;
        }
        public override string ToString()
        {
            return $"玩家{name}，血量{hp}，攻击力{atk}，防御力{dfd}";
        }
    }
    class SkillID
    {
        public int skillID;
        public SkillID(int id)
        {
            skillID = id;
        }
    }
    class Monster
    {
        public string name;
        public int hp;
        public int atk;
        public int dfd;
        public float dodgeRate;
        public SkillID mID;
        public Monster(string name, int hp, int atk, int dfd, float dodgeRate, SkillID id)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
            this.dfd = dfd;
            this.dodgeRate = dodgeRate;
            mID = id;
        }
        public override string ToString()
        {
            return $"玩家{name}，血量{hp}，攻击力{atk}，防御力{dfd}，技能id{mID.skillID}";
        }
        public Monster ShallowCopy()
        {
            return MemberwiseClone() as Monster;
        }
        public Monster DeepCopy()
        {
            Monster m = MemberwiseClone() as Monster;
            m.mID = new SkillID(mID.skillID);
            return m;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Practice1
            Player warrior = new Player("warrior", 100, 40, 58, 0.75f);
            Console.WriteLine(warrior);
            #endregion
            #region Practice2
            SkillID iD = new SkillID(1997);
            Monster A = new Monster("萝卜王", 60, 30, 15, 0.5f,iD);
            Monster B = A.DeepCopy();
            Console.WriteLine(A);
            Console.WriteLine(B);
            B.name = "雪山巨猿";
            B.hp = 120;
            B.mID.skillID = 2000;
            Console.WriteLine(A);
            Console.WriteLine(B);
            #endregion
        }
    }
}
