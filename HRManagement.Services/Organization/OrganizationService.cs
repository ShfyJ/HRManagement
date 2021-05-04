using HRManagement.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.Services.Organization
{
    public class OrganizationService : IOrganizationService
    {
        private readonly HRManageDBContext _db;

        public OrganizationService(HRManageDBContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse<Models.Department>> AddDepartment(Models.Department newDepartment)
        {
            try
            {
                await _db.Departments.AddAsync(newDepartment);
                await _db.SaveChangesAsync();

                return new ServiceResponse<Models.Department>
                {
                    Data = newDepartment,
                    Time = DateTime.Now,
                    Message = "Yangi departament qo'shildi",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Models.Department>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }
        }

        public async Task<ServiceResponse<Models.Group>> AddGroup(Models.Group newGroup)
        {
            try
            {
                await _db.Groups.AddAsync(newGroup);
                await _db.SaveChangesAsync();

                return new ServiceResponse<Models.Group>
                {
                    Data = newGroup,
                    Time = DateTime.Now,
                    Message = "Yangi guruh qo'shildi",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Models.Group>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }
        }


        public async Task<ServiceResponse<Models.Organization>> AddOrganization(Models.Organization newOrganization)
        {
            try
            {
                await _db.Organizations.AddAsync(newOrganization);
                await _db.SaveChangesAsync();

                return new ServiceResponse<Models.Organization>
                {
                    Data = newOrganization,
                    Time = DateTime.Now,
                    Message = "Yangi Korxona qo'shildi",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Models.Organization>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }
            
            
        }

        public async Task<ServiceResponse<Models.Section>> AddSection(Models.Section newSection)
        {
            try
            {
                await _db.Sections.AddAsync(newSection);
                await _db.SaveChangesAsync();

                return new ServiceResponse<Models.Section>
                {
                    Data = newSection,
                    Time = DateTime.Now,
                    Message = "Yangi bo'lim qo'shildi",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Models.Section>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }

        }

        public async Task<ServiceResponse<Models.Department>> DeleteDepartment(int id)
        {
            var department = _db.Departments.Find(id);

            if (department == null)
            {
                return new ServiceResponse<Models.Department>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = "Departament topilmadi",
                    IsSuccess = false
                };
            }

            try
            {
                department.Status = false;
                await _db.SaveChangesAsync();

                return new ServiceResponse<Models.Department>
                {
                    Data = department,
                    Time = DateTime.Now,
                    Message = "Department ro'yxatdan olib tashlandi",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Models.Department>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }
        }

        public async Task<ServiceResponse<Models.Group>> DeleteGroup(int id)
        {
            var group = _db.Groups.Find(id);

            if (group == null)
            {
                return new ServiceResponse<Models.Group>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = "Guruh topilmadi",
                    IsSuccess = false
                };
            }

            try
            {
                group.Status = false;
                await _db.SaveChangesAsync();

                return new ServiceResponse<Models.Group>
                {
                    Data = group,
                    Time = DateTime.Now,
                    Message = "Guruh ro'yxatdan olib tashlandi",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Models.Group>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }
        }

        public async Task<ServiceResponse<Models.Organization>> DeleteOrganization(int id)
        {
            var organization = _db.Organizations.Find(id);

            if(organization == null)
            {
                return new ServiceResponse<Models.Organization>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = "Organizatsiya topilmadi",
                    IsSuccess = false
                };
            }

            try
            {
                organization.Status = false;
                await _db.SaveChangesAsync();

                return new ServiceResponse<Models.Organization>
                {
                    Data = organization,
                    Time = DateTime.Now,
                    Message = "Korxona ro'yxatdan olib tashlandi",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Models.Organization>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }

        }

        public async Task<ServiceResponse<Models.Section>> DeleteSection(int id)
        {
            var section = _db.Sections.Find(id);

            if (section == null)
            {
                return new ServiceResponse<Models.Section>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = "Bo'lim topilmadi",
                    IsSuccess = false
                };
            }

            try
            {
                section.Status = false;
                await _db.SaveChangesAsync();

                return new ServiceResponse<Models.Section>
                {
                    Data = section,
                    Time = DateTime.Now,
                    Message = "Bo'lim ro'yxatdan olib tashlandi",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Models.Section>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }
        }

        public async Task<IEnumerable<Models.Department>> GetAllDepartmentsWithAllInfos()
        {
            return await _db.Departments
                .Where(d => d.Status == true)
                .Include(d => d.Sections)
                .ThenInclude(s => s.Groups)
                .OrderBy(d => d.DepartmentId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Models.Group>> GetAllGroupsWithAllInfos()
        {
            return await _db.Groups
                .Where(g => g.Status == true)
                .OrderBy(g => g.GroupId)
                .ToListAsync();
        }


        public async Task<IEnumerable<Models.Organization>> GetAllOrganizationsWithAllInfos()
        {
            return await _db.Organizations
                .Where(o => o.Status == true)
                .Include(o => o.Departments)
                .ThenInclude(d => d.Sections)
                .ThenInclude(s => s.Groups)
                .Include(o => o.Sections)
                .OrderBy(o => o.OrganizationId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Models.Section>> GetAllSectionsWithAllInfos()
        {
            return await _db.Sections
                 .Where(s => s.Status == true)
                 .Include(s => s.Groups)
                 .OrderBy(s => s.SectionId)
                 .ToListAsync();
        }

        public async Task<Models.Department> GetDepartmentById(int id)
        {
            return await _db.Departments
                .Include(d => d.Sections)
                .ThenInclude(s => s.Groups)
                .FirstOrDefaultAsync(d => d.DepartmentId == id);
        }

        public async Task<Models.Group> GetGroupById(int id)
        {
            return await _db.Groups
                .FirstOrDefaultAsync(g => g.GroupId == id);
        }

        public async Task<Models.Organization> GetOrganizationById(int id)
        {
            return await _db.Organizations
                .Include(o => o.Departments)
                .ThenInclude(d => d.Sections)
                .ThenInclude(s => s.Groups)
                .Include(o => o.Sections)
                .FirstOrDefaultAsync(o => o.OrganizationId == id);


        }

        public async Task<Models.Section> GetSectionById(int id)
        {
            return await _db.Sections
                .Include(s => s.Groups)
                .FirstOrDefaultAsync(s => s.SectionId == id);
        }

        public async Task<ServiceResponse<Models.Department>> UpdateDepartmentInfo(Models.Department departmentToBeUpdated, Models.Department department)
        {
            if (departmentToBeUpdated == null)
            {
                return new ServiceResponse<Models.Department>
                {
                    Time = DateTime.Now,
                    IsSuccess = false,
                    Message = "Departament Topilmadi!",
                    Data = null
                };
            }

            try
            {
                departmentToBeUpdated.DepartmentName = department.DepartmentName;
                departmentToBeUpdated.OrganizationId = department.OrganizationId;
                departmentToBeUpdated.Status = department.Status;

                await _db.SaveChangesAsync();

                return new ServiceResponse<Models.Department>
                {
                    Data = departmentToBeUpdated,
                    Time = DateTime.Now,
                    Message = "Departament malumotlariga o'zgartirishlar kiritildi",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Models.Department>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }
        }

        public async Task<ServiceResponse<Models.Group>> UpdateGroupInfo(Models.Group groupToBeUpdated, Models.Group group)
        {
            if (groupToBeUpdated == null)
            {
                return new ServiceResponse<Models.Group>
                {
                    Time = DateTime.Now,
                    IsSuccess = false,
                    Message = "Guruh Topilmadi!",
                    Data = null
                };
            }

            try
            {
                groupToBeUpdated.GroupName = group.GroupName;
                groupToBeUpdated.SectionId = group.SectionId;
                groupToBeUpdated.Status = group.Status;

                await _db.SaveChangesAsync();

                return new ServiceResponse<Models.Group>
                {
                    Data = groupToBeUpdated,
                    Time = DateTime.Now,
                    Message = "Guruh malumotlariga o'zgartirishlar kiritildi",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Models.Group>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }
        }

        public async Task<ServiceResponse<Models.Organization>> UpdateOrganizationInfo(Models.Organization organizationToBeUpdated, Models.Organization organization)
        {
            if (organizationToBeUpdated == null)
            {
                return new ServiceResponse<Models.Organization>
                {
                    Time = DateTime.Now,
                    IsSuccess = false,
                    Message = "Korxona Topilmadi!",
                    Data = null
                };
            }

            try
            {
                organizationToBeUpdated.OrganizationNameInEng = organization.OrganizationNameInEng;
                organizationToBeUpdated.OrganizationNameInEngShort = organization.OrganizationNameInEngShort;
                organizationToBeUpdated.OrganizationNameInKrillUz = organization.OrganizationNameInKrillUz;
                organizationToBeUpdated.OrganizationNameInKrillUzShort = organization.OrganizationNameInKrillUzShort;
                organizationToBeUpdated.OrganizationNameInLatinUz = organization.OrganizationNameInLatinUz;
                organizationToBeUpdated.OrganizationNameInLatinUzShort = organization.OrganizationNameInLatinUzShort;
                organizationToBeUpdated.OrganizationNameInRu = organization.OrganizationNameInRu;
                organizationToBeUpdated.OrganizationNameInRuShort = organization.OrganizationNameInRuShort;
                organizationToBeUpdated.Status = organization.Status;
                
                await _db.SaveChangesAsync();

                return new ServiceResponse<Models.Organization>
                {
                    Data = organizationToBeUpdated,
                    Time = DateTime.Now,
                    Message = "Korxona malumotlariga o'zgartirishlar kiritildi",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Models.Organization>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }
        }

        public async Task<ServiceResponse<Models.Section>> UpdateSectionInfo(Models.Section sectionToBeUpdated, Models.Section section)
        {
            if (sectionToBeUpdated == null)
            {
                return new ServiceResponse<Models.Section>
                {
                    Time = DateTime.Now,
                    IsSuccess = false,
                    Message = "Bo'lim Topilmadi!",
                    Data = null
                };
            }

            try
            {
                sectionToBeUpdated.SectionName = section.SectionName;
                sectionToBeUpdated.DepartmentId = section.DepartmentId;
                sectionToBeUpdated.OrganizationId = section.OrganizationId;
                sectionToBeUpdated.IsDepartmentSection = section.IsDepartmentSection;
                sectionToBeUpdated.IsIndependentSection = section.IsIndependentSection;
                sectionToBeUpdated.Status = section.Status;

                await _db.SaveChangesAsync();

                return new ServiceResponse<Models.Section>
                {
                    Data = sectionToBeUpdated,
                    Time = DateTime.Now,
                    Message = "Bo'lim malumotlariga o'zgartirishlar kiritildi",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Models.Section>
                {
                    Data = null,
                    Time = DateTime.Now,
                    Message = e.StackTrace,
                    IsSuccess = false
                };
            }
        }
    }
}
