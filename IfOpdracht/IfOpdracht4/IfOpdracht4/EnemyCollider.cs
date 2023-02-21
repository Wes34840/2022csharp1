namespace IfOpdracht4
{
    internal class EnemyCollider
    {
        internal bool CanPassWall(Enemy enemy)
        {
            //gebruik hier een || (OR)
            //je kan enemy.??? gebruiken om de eigenschap te testen, bv voor flying wordt het enemy.flying
            //vervang false, een enemy mag door een muur als 1 van  (flying,incoporial,subterranian) true is;
            if (enemy.flying == true || enemy.incoporial == true || enemy.subterranian == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal bool CanPassWater(Enemy enemy)
        {
            //gebruik hier een || (OR)
            //je kan enemy.??? gebruiken om de eigenschap te testen, bv voor flying wordt het enemy.flying
            //vervang false, een enemy mag door een muur als 1 van  (flying,incoporial,subterranian,swimmer) true is;
            if (enemy.flying == true || enemy.incoporial == true || enemy.subterranian == true || enemy.swimmer == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}