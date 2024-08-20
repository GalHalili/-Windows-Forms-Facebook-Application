using System;
using System.Reflection;

namespace BasicFacebookFeatures
{
    public static class Singleton<T>
        where T : class
    {
        private static T s_Instance = null;

        static Singleton() { }

        public static T Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    ConstructorInfo constructor = typeof(T).GetConstructor(
                        BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public,
                        null,
                        Type.EmptyTypes,
                        null);
                    if (constructor == null)
                    {
                        throw new Exception($"A private or protected constructor is missing for '{typeof(T).Name}'.");
                    }

                    s_Instance = (T)constructor.Invoke(null);
                }

                return s_Instance;
            }
        }
    }
}