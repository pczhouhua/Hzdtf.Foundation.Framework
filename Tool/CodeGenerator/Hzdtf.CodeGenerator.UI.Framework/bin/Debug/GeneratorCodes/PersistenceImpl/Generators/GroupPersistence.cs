﻿﻿using hzdtd.Model.Standard;
using Hzdtf.MySql.Standard;
using Hzdtf.Utility.Standard.Attr;
using System;
using hzdtd.Persistence.Contract.Standard;

namespace hzdtd.MySql.Standard
{
    /// <summary>
    /// 持久化
    /// @ 黄振东
    /// </summary>
    [Inject]
    public partial class GroupPersistence : MySqlDapperBase<GroupInfo>, IGroupPersistence
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string Table => "group";

        /// <summary>
        /// 插入字段名称集合
        /// </summary>
        private readonly static string[] INSERT_FIELD_NAMES = new string[]
        {
            "create_time",
            "creator",
            "creator_id",
            "curr_serial_no",
            "is_temp",
            "last_send_time",
            "modifier",
            "modifier_id",
            "modify_time",
            "name",
            "parent_id",
            "status",
        };

        /// <summary>
        /// 更新字段名称集合
        /// </summary>
        private readonly static string[] UPDATE_FIELD_NAMES = new string[]
        {
            "creator",
            "creator_id",
            "curr_serial_no",
            "is_temp",
            "last_send_time",
            "modifier",
            "modifier_id",
            "modify_time",
            "name",
            "parent_id",
            "status",
        };

        /// <summary>
        /// 所有字段映射集合
        /// </summary>
        private readonly static string[] FIELD_MAP_PROPS = new string[]
        {
            "create_time CreateTime",
            "creator Creator",
            "creator_id CreatorId",
            "curr_serial_no CurrSerialNo",
            "id Id",
            "is_temp IsTemp",
            "last_send_time LastSendTime",
            "modifier Modifier",
            "modifier_id ModifierId",
            "modify_time ModifyTime",
            "name Name",
            "parent_id ParentId",
            "status Status",
        };

        /// <summary>
        /// 根据字段名获取模型的值
        /// </summary>
        /// <param name="model">模型</param>
        /// <param name="field">字段名</param>
        /// <returns>值</returns>
        protected override object GetValueByFieldName(GroupInfo model, string field)
        {
            switch (field)
            {
﻿                case "create_time":
                    return model.CreateTime;

﻿                case "creator":
                    return model.Creator;

﻿                case "creator_id":
                    return model.CreatorId;

﻿                case "curr_serial_no":
                    return model.CurrSerialNo;

﻿                case "id":
                    return model.Id;

﻿                case "is_temp":
                    return model.IsTemp;

﻿                case "last_send_time":
                    return model.LastSendTime;

﻿                case "modifier":
                    return model.Modifier;

﻿                case "modifier_id":
                    return model.ModifierId;

﻿                case "modify_time":
                    return model.ModifyTime;

﻿                case "name":
                    return model.Name;

﻿                case "parent_id":
                    return model.ParentId;

﻿                case "status":
                    return model.Status;

                default:
                    return null;
            }
        }

        /// <summary>
        /// 插入字段名集合
        /// </summary>
        /// <returns>插入字段名集合</returns>
        protected override string[] InsertFieldNames() => INSERT_FIELD_NAMES;

        /// <summary>
        /// 更新字段名称集合
        /// </summary>
        /// <returns>更新字段名称集合</returns>
        protected override string[] UpdateFieldNames() => UPDATE_FIELD_NAMES;

		/// <summary>
        /// 所有字段映射集合
        /// </summary>
        /// <returns>所有字段映射集合</returns>
        public override string[] AllFieldMapProps() => FIELD_MAP_PROPS;
    }
}
