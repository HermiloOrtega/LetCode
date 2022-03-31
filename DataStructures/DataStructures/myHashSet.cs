using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class myHashSet
    {
        private Bucket[] bucketArray;

        private int keyRange;

        public myHashSet(){
            this.keyRange = 769;
            this.bucketArray = new Bucket[this.keyRange];
            for (int i = 0; i < this.keyRange; i++){
                this.bucketArray[i] = new Bucket();
            }
        }
        protected int _hash(int key){
            return (key % this.keyRange);
        }

        public void add(int key){
            int bucketIndex = this._hash(key);
            this.bucketArray[bucketIndex].insert(key);
        }

        public void remove(int key){
            int bucketIndex = this._hash(key);
            this.bucketArray[bucketIndex].delete(key);
        }

        public bool contains(int key){
            int bucketIndex = this._hash(key);
            return this.bucketArray[bucketIndex].exists(key);
        }
    }
    class Bucket
    {
        private List<int> container;

        public Bucket(){
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
        public bool exists(int key){
            int index = this.container.IndexOf(key);
            return (index != -1);
        }
    }
}
