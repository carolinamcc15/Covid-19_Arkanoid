using System;
using System.Data;

namespace Covid_19_Arkanoid
{
    public static class Top10DAO
    {
        public static DataTable GetTop10()
        {
            String sql = String.Format("SELECT pl.nickname, sc.score FROM PLAYER pl, SCORE sc " +
                                       "WHERE pl.playerID = sc.playerID ORDER BY score DESC FETCH FIRST 10 ROWS ONLY;");
            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            return dt;
        }
    }
}