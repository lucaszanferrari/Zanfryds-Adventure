﻿using UnityEngine;

namespace MalbersAnimations
{
    public class ActiveMesh : MonoBehaviour
    {
        public Transform[] meshes;
        int current;

        public void ChangeMesh()
        {
            foreach (var item in meshes)
            {
                if (item) item.gameObject.SetActive(false);
            }
            current++;
            if (current >= meshes.Length) current = 0;
            if (meshes[current]) meshes[current].gameObject.SetActive(true);
        }
    }
}