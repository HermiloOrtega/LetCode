using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class myHashSet
    {

    }
    class Bucket
    {
        private List<int> container;

        public Bucket()
        {
            this.container = new List<int>();
        }
        public void insert(int key){
            int index = this.container.IndexOf(key);
            if (index == -1){
                this.container.Insert(0, key);
            }
        }
        public void delete(int key){
            this.container.Remove(key);
        }
        public bool exists(int key)
        {
            int index = this.container.IndexOf(key);
            return (index != -1);
        }
    }
}
