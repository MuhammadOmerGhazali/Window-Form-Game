using System.Collections.Generic;
using System.Windows.Forms;

namespace Game_Backend.BL
{
    public class Game
    {
        List<GameObject> gameObjectList;
        Form Container;
        public Game(Form container)
        {
            Container = container;
            gameObjectList = new List<GameObject>();
        }
        public void Add(GameObject gameObject)
        {
            gameObjectList.Add(gameObject);
        }
        public void Remove(GameObject gameObject)
        {
            gameObjectList.Remove(gameObject);
        }
        public void Update()
        {
            foreach (GameObject gameObject in gameObjectList)
            {
                gameObject.update();
            }
        }
        public void AddobjectToForm(GameObject node)
        {
            Container.Controls.Add(node.GetSprite());
        }
    }
}
