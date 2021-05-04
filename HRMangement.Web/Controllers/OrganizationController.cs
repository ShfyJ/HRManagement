using AutoMapper;
using HRManagement.Services.Organization;
using HRManagement.Web.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Web.Controllers
{
    public class OrganizationController : Controller
    {
        private readonly ILogger<OrganizationController> _logger;
        private readonly IOrganizationService _organizationService;
        private readonly IMapper _mapper;

        public OrganizationController(ILogger<OrganizationController> logger, IOrganizationService organizationService, IMapper mapper)
        {
            _logger = logger;
            _organizationService = organizationService;
            _mapper = mapper;
        }

        #region Organization APIs starts here ...
        [HttpGet("organization")]
        public async Task<ActionResult<IEnumerable<OrganizationResource>>> GetAllOrganizationsWithAllInfos()
        {
            _logger.LogInformation("Getting all organizations");
            var organizations = await _organizationService.GetAllOrganizationsWithAllInfos();
            var organizationResources = _mapper.Map<IEnumerable<Models.Organization>, IEnumerable<OrganizationResource>>(organizations);

            return Ok(organizationResources);
        }

        [HttpGet("Organization/{id}")]
        public async Task<ActionResult<OrganizationResource>> GetOrganizationById(int id)
        {
            _logger.LogInformation("Getting organization by Id");
            var organization = await _organizationService.GetOrganizationById(id);
            var organizationResource = _mapper.Map<Models.Organization, OrganizationResource>(organization);

            return Ok(organizationResource);
        }

        [HttpPost("organization")]
        public async Task<ActionResult<OrganizationResource>> AddOrganization([FromBody] SaveOrganizationResource saveOrganizationResource)
        {
            _logger.LogInformation("Adding new organization to DB");
            var organizationToAdd = _mapper.Map<SaveOrganizationResource, Models.Organization>(saveOrganizationResource);

            var serviceResponce = await _organizationService.AddOrganization(organizationToAdd);

            if(serviceResponce.Data != null)
            {
                var organization = await _organizationService.GetOrganizationById(serviceResponce.Data.OrganizationId);

                var organizationResource = _mapper.Map<Models.Organization, OrganizationResource>(organization);

                return Ok(organizationResource);
            }

            return BadRequest(serviceResponce.Message);

        }

        [HttpPut("Organization/{id}")]
        public async Task<ActionResult<OrganizationResource>> UpdateOrganization(int id, [FromBody] SaveOrganizationResource saveOrganizationResource)
        {
            _logger.LogInformation("Editing a organization");
            var organizationToBeUpdate = await _organizationService.GetOrganizationById(id);

            if (organizationToBeUpdate == null)
                return NotFound();

            var organization = _mapper.Map<SaveOrganizationResource, Models.Organization>(saveOrganizationResource);

            await _organizationService.UpdateOrganizationInfo(organizationToBeUpdate, organization);

            var updatedOrganization = await _organizationService.GetOrganizationById(id);
            var updatedOrganizationResource = _mapper.Map<Models.Organization, OrganizationResource>(updatedOrganization);

            return Ok(updatedOrganizationResource);
        }

        [HttpPatch("Organization/{id}")]
        public async Task<ActionResult> DeleteOrganization(int id)
        {
            _logger.LogInformation("Removing a organization/changing its status to false");
            if (id == 0)
                return BadRequest();

            await _organizationService.DeleteOrganization(id);

            return NoContent();
        }

        #endregion

        #region Department APIs starts here ...
        [HttpGet("Department")]
        public async Task<ActionResult<IEnumerable<DepartmentResource>>> GetAllDepartmentsWithAllInfos()
        {
            _logger.LogInformation("Getting all departments");
            var departments = await _organizationService.GetAllDepartmentsWithAllInfos();
            var departmentResources = _mapper.Map<IEnumerable<Models.Department>, IEnumerable<DepartmentResource>>(departments);

            return Ok(departmentResources);
        }

        [HttpGet("Department/{id}")]
        public async Task<ActionResult<DepartmentResource>> GetDepartmentById(int id)
        {
            _logger.LogInformation("Getting department by Id");
            var department = await _organizationService.GetDepartmentById(id);
            var departmentResource = _mapper.Map<Models.Department, DepartmentResource>(department);

            return Ok(departmentResource);
        }

        [HttpPost("Department")]
        public async Task<ActionResult<DepartmentResource>> AddDepartment([FromBody] SaveDepartmentResource saveDepartmentResource)
        {
            _logger.LogInformation("Adding new department to DB");
            var departmentToAdd = _mapper.Map<SaveDepartmentResource, Models.Department>(saveDepartmentResource);

            var serviceResponce = await _organizationService.AddDepartment(departmentToAdd);

            if (serviceResponce.Data != null)
            {
                var department = await _organizationService.GetDepartmentById(serviceResponce.Data.DepartmentId);

                var departmentResource = _mapper.Map<Models.Department, DepartmentResource>(department);

                return Ok(departmentResource);
            }

            return BadRequest(serviceResponce.Message);

        }

        [HttpPut("Department{id}")]
        public async Task<ActionResult<DepartmentResource>> UpdateDepartment(int id, [FromBody] SaveDepartmentResource saveDepartmentResource)
        {
            _logger.LogInformation("Editing a department");
            var departmentToBeUpdate = await _organizationService.GetDepartmentById(id);

            if (departmentToBeUpdate == null)
                return NotFound();

            var department = _mapper.Map<SaveDepartmentResource, Models.Department>(saveDepartmentResource);

            await _organizationService.UpdateDepartmentInfo(departmentToBeUpdate, department);

            var updatedDepartment = await _organizationService.GetDepartmentById(id);
            var updatedDepartmentResource = _mapper.Map<Models.Department, DepartmentResource>(updatedDepartment);

            return Ok(updatedDepartmentResource);
        }

        [HttpPatch("Department{id}")]
        public async Task<ActionResult> DeleteDepartment(int id)
        {
            _logger.LogInformation("Removing a department/changing its status to false");
            if (id == 0)
                return BadRequest();

            await _organizationService.DeleteDepartment(id);

            return NoContent();
        }

        #endregion

        #region Section APIs starts here ...
        [HttpGet("Section")]
        public async Task<ActionResult<IEnumerable<SectionResource>>> GetAllSectionsWithAllInfos()
        {
            _logger.LogInformation("Getting all Sections");
            var sections = await _organizationService.GetAllSectionsWithAllInfos();
            var sectionResources = _mapper.Map<IEnumerable<Models.Section>, IEnumerable<SectionResource>>(sections);

            return Ok(sectionResources);
        }

        [HttpGet("Section/{id}")]
        public async Task<ActionResult<SectionResource>> GetSectionById(int id)
        {
            _logger.LogInformation("Getting Section by Id");
            var section = await _organizationService.GetSectionById(id);
            var sectionResource = _mapper.Map<Models.Section, SectionResource>(section);

            return Ok(sectionResource);
        }

        [HttpPost("Section")]
        public async Task<ActionResult<SectionResource>> AddSection([FromBody] SaveSectionResource saveSectionResource)
        {
            _logger.LogInformation("Adding new Section to DB");
            var sectionToAdd = _mapper.Map<SaveSectionResource, Models.Section>(saveSectionResource);

            var serviceResponce = await _organizationService.AddSection(sectionToAdd);

            if (serviceResponce.Data != null)
            {
                var section = await _organizationService.GetSectionById(serviceResponce.Data.SectionId);

                var sectionResource = _mapper.Map<Models.Section, SectionResource>(section);

                return Ok(sectionResource);
            }

            return BadRequest(serviceResponce.Message);

        }

        [HttpPut("Section{id}")]
        public async Task<ActionResult<SectionResource>> UpdateSection(int id, [FromBody] SaveSectionResource saveSectionResource)
        {
            _logger.LogInformation("Editing a Section");
            var sectionToBeUpdate = await _organizationService.GetSectionById(id);

            if (sectionToBeUpdate == null)
                return NotFound();

            var section = _mapper.Map<SaveSectionResource, Models.Section>(saveSectionResource);

            await _organizationService.UpdateSectionInfo(sectionToBeUpdate, section);

            var updatedSection = await _organizationService.GetSectionById(id);
            var updatedSectionResource = _mapper.Map<Models.Section, SectionResource>(updatedSection);

            return Ok(updatedSectionResource);
        }

        [HttpPatch("Section{id}")]
        public async Task<ActionResult> DeleteSection(int id)
        {
            _logger.LogInformation("Removing a Section/changing its status to false");
            if (id == 0)
                return BadRequest();

            await _organizationService.DeleteSection(id);

            return NoContent();
        }

        #endregion

        #region Group APIs starts here ...
        [HttpGet("Group")]
        public async Task<ActionResult<IEnumerable<GroupResource>>> GetAllGroupsWithAllInfos()
        {
            _logger.LogInformation("Getting all Groups");
            var groups = await _organizationService.GetAllGroupsWithAllInfos();
            var groupResources = _mapper.Map<IEnumerable<Models.Group>, IEnumerable<GroupResource>>(groups);

            return Ok(groupResources);
        }

        [HttpGet("Group/{id}")]
        public async Task<ActionResult<GroupResource>> GetGroupById(int id)
        {
            _logger.LogInformation("Getting Group by Id");
            var group = await _organizationService.GetGroupById(id);
            var groupResource = _mapper.Map<Models.Group, GroupResource>(group);

            return Ok(groupResource);
        }

        [HttpPost("Group")]
        public async Task<ActionResult<GroupResource>> AddGroup([FromBody] SaveGroupResource saveGroupResource)
        {
            _logger.LogInformation("Adding new Group to DB");
            var groupToAdd = _mapper.Map<SaveGroupResource, Models.Group>(saveGroupResource);

            var serviceResponce = await _organizationService.AddGroup(groupToAdd);

            if (serviceResponce.Data != null)
            {
                var group = await _organizationService.GetGroupById(serviceResponce.Data.GroupId);

                var groupResource = _mapper.Map<Models.Group, GroupResource>(group);

                return Ok(groupResource);
            }

            return BadRequest(serviceResponce.Message);

        }

        [HttpPut("Group{id}")]
        public async Task<ActionResult<GroupResource>> UpdateGroup(int id, [FromBody] SaveGroupResource saveGroupResource)
        {
            _logger.LogInformation("Editing a Group");
            var groupToBeUpdate = await _organizationService.GetGroupById(id);

            if (groupToBeUpdate == null)
                return NotFound();

            var group = _mapper.Map<SaveGroupResource, Models.Group>(saveGroupResource);

            await _organizationService.UpdateGroupInfo(groupToBeUpdate, group);

            var updatedGroup = await _organizationService.GetGroupById(id);
            var updatedGroupResource = _mapper.Map<Models.Group, GroupResource>(updatedGroup);

            return Ok(updatedGroupResource);
        }

        [HttpPatch("Group{id}")]
        public async Task<ActionResult> DeleteGroup(int id)
        {
            _logger.LogInformation("Removing a Group/changing its status to false");
            if (id == 0)
                return BadRequest();

            await _organizationService.DeleteGroup(id);

            return NoContent();
        }

        #endregion

    }
}
