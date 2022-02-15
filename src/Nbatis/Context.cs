namespace Nbatis
{
    public abstract class Context
    {
        /// <summary>
        /// 执行一条查询语句，返回结果集
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public abstract List<T> SelectList<T>(string mapperId);
        public abstract void SelectOne(string mapperId);
        public abstract int Insert(string mapperId);
        public abstract int Update(string mapperId);
        public abstract int Delete(string mapperId);
    }
}