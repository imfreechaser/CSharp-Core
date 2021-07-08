using System;

namespace Lesson13_继承_里氏替换原则
{
    class Monster
    {
        public void Atk()
        {
            Console.WriteLine("攻击");
        }
    }
    class Boss : Monster
    {
        public void Skill()
        {
            Console.WriteLine("释放技能");
        }
    }
    class Goblin : Monster
    {

    }

    #region Practice2
    class Player
    {
        public void PickUpWeapon(Weapon w)
        {
            w.GetWeapon(w);
        }
    }
    //解法1
    class Weapon
    {
        protected uint hurt;
        public void GetWeapon(Weapon w)
        {
            string weapon;
            if (w is SMG)
                weapon = "冲锋枪";
            else if(w is ShotGun)
                weapon = "霰弹枪";
            else if(w is Pistol)
                weapon = "手枪";
            else
                weapon = "匕首";
            Console.WriteLine("玩家拾取了武器：{0}", weapon);
        }
    }
    class SMG : Weapon
    {

    }
    class ShotGun : Weapon
    {

    }
    class Pistol : Weapon
    {

    }
    class Dagger : Weapon
    {

    }
    
    //解法2
    //class Weapon
    //{
    //    protected uint hurt;
    //    virtual public void GetWeapon()
    //    {
    //        string weapon = "武器";
    //        Console.WriteLine("玩家拾取了武器：{0}", weapon);
    //    }
    //}
    //class SMG : Weapon
    //{
    //    override public void GetWeapon()
    //    {
    //        string weapon = "冲锋枪";
    //        Console.WriteLine("玩家拾取了武器：{0}", weapon);
    //    }
    //}
    //class ShotGun : Weapon
    //{
    //    override public void GetWeapon()
    //    {
    //        string weapon = "霰弹枪";
    //        Console.WriteLine("玩家拾取了武器：{0}", weapon);
    //    }
    //}
    //class Pistol : Weapon
    //{
    //    override public void GetWeapon()
    //    {
    //        string weapon = "手枪";
    //        Console.WriteLine("玩家拾取了武器：{0}", weapon);
    //    }
    //}
    //class Dagger : Weapon
    //{
    //    override public void GetWeapon()
    //    {
    //        string weapon = "匕首";
    //        Console.WriteLine("玩家拾取了武器：{0}", weapon);
    //    }
    //}
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            //Monster[] monsters = new Monster[10];
            //Random r = new Random();

            //for (int i = 0; i < monsters.Length; i++)
            //{
            //    int type = r.Next(0,2);
            //    if(type == 0)
            //    {
            //        monsters[i] = new Boss();
            //        (monsters[i] as Boss).Skill();

            //    }
            //    else
            //        monsters[i] = new Goblin();
            //}

            Player p = new Player();
            p.PickUpWeapon(new ShotGun());
        }
    }
}
