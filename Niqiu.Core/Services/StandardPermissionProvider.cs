using System.Collections.Generic;
using Niqiu.Core.Domain.Security;
using Niqiu.Core.Domain.User;

namespace Niqiu.Core.Services
{
    /// <summary>
    /// Standard permission provider
    /// </summary>
    public partial class StandardPermissionProvider : IPermissionProvider
    {
        //�����̨
        public static readonly PermissionRecord AccessAdminPanel = new PermissionRecord { Name = "�����̨", SystemName = "AccessAdminPanel", Category = "Standard" };
        //��ɫ����
        public static readonly PermissionRecord EditRole = new PermissionRecord { Name = "�༭��ɫ", SystemName = "EditRole", Category = "Standard" };
        public static readonly PermissionRecord CreateRole = new PermissionRecord { Name = "���ӽ�ɫ", SystemName = "CreateRole", Category = "Standard" };
        public static readonly PermissionRecord EditUser = new PermissionRecord { Name = "�༭�û�", SystemName = "EditUser", Category = "Standard" };
        public static readonly PermissionRecord CreateUser = new PermissionRecord { Name = "�����û�", SystemName = "CreateUser", Category = "Standard" };
        public static readonly PermissionRecord EditAdmin = new PermissionRecord { Name = "�༭����Ա", SystemName = "EditAdmin", Category = "Standard" };
        public static readonly PermissionRecord CreateAdmin = new PermissionRecord { Name = "���ӹ���Ա", SystemName = "CreateAdmin", Category = "Standard" };
        //������Ʒ
        //public static readonly PermissionRecord ManageProducts = new PermissionRecord { Name = "������Ʒ", SystemName = "ManageProducts", Category = "Catalog" };
        ////��������
        //public static readonly PermissionRecord ManageCategories = new PermissionRecord { Name = "��������", SystemName = "ManageCategories", Category = "Catalog" };
        ////�����û�
        //public static readonly PermissionRecord ManageUsers = new PermissionRecord { Name = "�����û�", SystemName = "ManageUsers", Category = "Users" };
        ////��������
        //public static readonly PermissionRecord ManageOrders = new PermissionRecord { Name = "��������", SystemName = "ManageOrders", Category = "Orders" };
        ////��������
        //public static readonly PermissionRecord ManageNews = new PermissionRecord { Name = "��������", SystemName = "ManageNews", Category = "Content Management" };
        ////�������� ���İ�
        //public static readonly PermissionRecord ManageBlog = new PermissionRecord { Name = "��������", SystemName = "ManageBlog", Category = "Content Management" };
        ////�������
        //public static readonly PermissionRecord ManagePlugins = new PermissionRecord { Name = "�������", SystemName = "ManagePlugins", Category = "Configuration" };
        ////��������
        //public static readonly PermissionRecord ManageTopics = new PermissionRecord { Name = "��������", SystemName = "ManageTopics", Category = "Content Management" };
        ////������̳
        //public static readonly PermissionRecord ManageForums = new PermissionRecord { Name = "������̳", SystemName = "ManageForums", Category = "Content Management" };
        ////����ϵͳ��־
        //public static readonly PermissionRecord ManageSystemLog = new PermissionRecord { Name = "������־", SystemName = "ManageSystemLog", Category = "Configuration" };
     
        ////������������
        //public static readonly PermissionRecord ManageDownloadFiles = new PermissionRecord { Name = "�����ļ�", SystemName = "DownloadFiles", Category = "Content Management" };
        ////��������ʦ-->ָ��˭�ǹ���ʦ
        //public static readonly PermissionRecord ManageEngineers = new PermissionRecord { Name = "��������ʦ", SystemName = "ManageEngineers", Category = "Users" };
        ////����ʦ����Ȩ���ش�����
        //public static readonly PermissionRecord ManageQuestiones = new PermissionRecord { Name = "��������", SystemName = "ManageQuestiones", Category = "Content Management" };

        ////���ͻ���Ȩ�� �����򹤳�ʦ����
        //public static readonly PermissionRecord AskQuestion = new PermissionRecord { Name = "�����ʴ�", SystemName = "AskQuestion", Category = "Support" };

        ////�����̻�
        //public static readonly PermissionRecord ManageTenant = new PermissionRecord { Name = "�����̻�", SystemName = "ManageTenant", Category = "Users" };

        //public static readonly PermissionRecord SearchOrder = new PermissionRecord { Name = "������ѯ", SystemName = "SearchOrder", Category = "Users" };
         


        public virtual IEnumerable<PermissionRecord> GetPermissions()
        {
            return new[] 
            {
                AccessAdminPanel,EditRole,CreateRole,EditUser,CreateUser,CreateAdmin,EditAdmin
            };
        }


        public virtual IEnumerable<DefaultPermissionRecord> GetDefaultPermissions()
        {
            return new[] 
            {
                new DefaultPermissionRecord 
                {
                    UserRoleSystemName = SystemUserRoleNames.Administrators,
                    PermissionRecords =GetPermissions() 
                },
                new DefaultPermissionRecord
                {
                   UserRoleSystemName   = SystemUserRoleNames.Admin,
                   PermissionRecords = new []
                   {
                       AccessAdminPanel,
                       EditUser,
                       CreateUser,
                   }
                },

               new DefaultPermissionRecord
                {
                   UserRoleSystemName   = SystemUserRoleNames.Employeer,
                   PermissionRecords = new []
                   {
                       AccessAdminPanel,
                   }
                },
 
            };
        }
    }
}