﻿#region

using db;
using System.Collections.Generic;
using wServer.networking.svrPackets;

#endregion

namespace wServer.realm.entities.player
{
    partial class Player
    {
        public void SendAccountList(List<string> list, int id)
        {
            for (int i = 0; i < list.Count; i++)
                list[i] = list[i].Trim();

            Client.SendPacket(new AccountListPacket
            {
                AccountListId = id,
                AccountIds = list.ToArray(),
                LockAction = -1
            });
        }

        public bool IsUserInLegends()
        {
            //Week
            using (Database db = new Database())
            {
                var cmd = db.CreateQuery();
                cmd.CommandText = "SELECT * FROM death WHERE (time >= DATE_SUB(NOW(), INTERVAL 1 WEEK)) ORDER BY totalFame DESC LIMIT 10;";
                using (var rdr = cmd.ExecuteReader())
                    while (rdr.Read())
                        if (rdr.GetString("accId") == AccountId) return true;
            }

            //Month
            using (Database db = new Database())
            {
                var cmd = db.CreateQuery();
                cmd.CommandText = "SELECT * FROM death WHERE (time >= DATE_SUB(NOW(), INTERVAL 1 MONTH)) ORDER BY totalFame DESC LIMIT 10;";
                using (var rdr = cmd.ExecuteReader())
                    while (rdr.Read())
                        if (rdr.GetString("accId") == AccountId) return true;
            }
            //All Time
            using (Database db = new Database())
            {
                var cmd = db.CreateQuery();
                cmd.CommandText = "SELECT * FROM death WHERE TRUE ORDER BY totalFame DESC LIMIT 10;";
                using (var rdr = cmd.ExecuteReader())
                    while (rdr.Read())
                        if (rdr.GetString("accId") == AccountId) return true;
            }

            return false;
        }
    }
}