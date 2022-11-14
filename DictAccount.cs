using System.Collections;

class DictAccount:DictionaryBase{
    public void Add(string key, Account value){
        base.InnerHashtable.Add(key, value);
    }
    public void Remove(string key){
        base.InnerHashtable.Remove(key);
    }
    public Account Item(string key){
        return (Account)base.InnerHashtable[key];
    }
}