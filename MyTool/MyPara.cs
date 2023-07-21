using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusActivityManagementSystem
{
    internal static class MyPara
    {
        public static Color buttonColor = Color.FromArgb(24, 144, 255);
        public static Color warningTextColor = Color.FromArgb(255, 61, 46);
        public static Color exitColor = Color.FromArgb(217, 26, 26);
        public static Color sideBarColor = Color.FromArgb(82, 138, 179);
        public static Color sideTitleColor = Color.FromArgb(28, 62, 127);
        public static Color listButtonColor = Color.FromArgb(26, 88, 206);
        public static Color sideItemColor = Color.FromArgb(24, 144, 255);
        public static Color sideItemTextColor = Color.FromArgb(207, 210, 217);

        public static Hashtable states = new Hashtable() { { 1, "未提交" }, { 2, "待审核" }, { 3, "未通过" },
                    { 4, "审核过期" }, { 5, "待报名" }, { 6, "报名中" }, { 7, "待开始" }, { 8, "活动中" },
                    { 9, "已结束" }, { 10, "已上报" }, { 11, "已完成" }};

        public static Hashtable statesBack = new Hashtable() { { "未提交", 1 }, { "待审核", 2 }, { "未通过", 3 },
                    { "审核过期", 4 }, { "待报名", 5 }, { "报名中", 6 }, { "待开始", 7 }, { "活动中", 8 },
                    { "已结束", 9 }, { "已上报", 10 }, { "已完成", 11 }};
    }
}
