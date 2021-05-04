using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.Services.Organization
{
    public interface IOrganizationService
    {
        #region Organization methods ...
        Task<IEnumerable<Models.Organization>> GetAllOrganizationsWithAllInfos();
        Task<Models.Organization> GetOrganizationById(int id);
        Task<ServiceResponse<Models.Organization>> AddOrganization(Models.Organization newOrganization);
        Task<ServiceResponse<Models.Organization>> UpdateOrganizationInfo(Models.Organization organizationToBeUpdated, Models.Organization organization);
        Task<ServiceResponse<Models.Organization>> DeleteOrganization(int id);
        #endregion

        #region Department methods ...
        Task<IEnumerable<Models.Department>> GetAllDepartmentsWithAllInfos();
        Task<Models.Department> GetDepartmentById(int id);
        Task<ServiceResponse<Models.Department>> AddDepartment(Models.Department newDepartment);
        Task<ServiceResponse<Models.Department>> UpdateDepartmentInfo(Models.Department departmentToBeUpdated, Models.Department department);
        Task<ServiceResponse<Models.Department>> DeleteDepartment(int id);
        #endregion

        #region Section methods ...
        Task<IEnumerable<Models.Section>> GetAllSectionsWithAllInfos();
        Task<Models.Section> GetSectionById(int id);
        Task<ServiceResponse<Models.Section>> AddSection(Models.Section newSection);
        Task<ServiceResponse<Models.Section>> UpdateSectionInfo(Models.Section sectionToBeUpdated, Models.Section section);
        Task<ServiceResponse<Models.Section>> DeleteSection(int id);
        #endregion

        #region Group methods ...
        Task<IEnumerable<Models.Group>> GetAllGroupsWithAllInfos();
        Task<Models.Group> GetGroupById(int id);
        Task<ServiceResponse<Models.Group>> AddGroup(Models.Group newGroup);
        Task<ServiceResponse<Models.Group>> UpdateGroupInfo(Models.Group groupToBeUpdated, Models.Group group);
        Task<ServiceResponse<Models.Group>> DeleteGroup(int id);
        #endregion
    }
}
