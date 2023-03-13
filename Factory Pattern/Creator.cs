using UnityEngine;

namespace Factory_Pattern
{
    public class Creator : MonoBehaviour
    {
        void Start()
        {
            Factory blueCube = FactoryMethod(Colors.Blue);
            Factory greenCube = FactoryMethod(Colors.Green);
            Factory redCube = FactoryMethod(Colors.Red);
            Debug.Log($"I'm a {blueCube.Name()} Cube.");
            Debug.Log($"I'm a {greenCube.Name()} Cube.");
            Debug.Log($"I'm a {redCube.Name()} Cube.");
        }

        public Factory FactoryMethod(Colors colors)
        {
            Factory factory = colors switch
            {
                Colors.Red => new RedCube(),
                Colors.Green => new GreenCube(),
                Colors.Blue => new BlueCube(),
                _ => null,
            };
            return factory;

        }
    }
}
