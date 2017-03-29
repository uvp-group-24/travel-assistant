using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project.Picture
{
    class Scene
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string blabla { get; set; }
        public string Description { get; set; }
    }

    class SceneManager
    {
        public static List<Scene> GetScene()
        {
            var AllScene = new List<Scene>();

            AllScene.Add(new Scene { Id = 1, Name = "I'm scene1", blabla = "beautiful~", Description = "Assets/scenery1.jpg" });
            AllScene.Add(new Scene { Id = 2, Name = "I'm scene2", blabla = "spectacular~", Description = "Assets/scenery2.jpg" });
            AllScene.Add(new Scene { Id = 3, Name = "I'm scene3", blabla = "magnificent~", Description = "Assets/scenery3.jpg" });
            AllScene.Add(new Scene { Id = 4, Name = "I'm scene4", blabla = "good~", Description = "Assets/scenery4.jpg" });
            AllScene.Add(new Scene { Id = 5, Name = "I'm scene5", blabla = "perfect~", Description = "Assets/scenery5.jpg" });

            return AllScene;
        }

    }
}
