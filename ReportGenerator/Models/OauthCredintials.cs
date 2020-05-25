﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevOpsTestCases.Models
{
    public class OauthCredintials
    {

        public string url = "https://app.vssps.visualstudio.com/oauth2/authorize?client_id={0}&response_type=Assertion&state=User1&scope=vso.analytics vso.auditlog vso.build_execute vso.code_full vso.connected_server vso.dashboards_manage vso.entitlements vso.environment_manage vso.extension.data_write vso.extension_manage vso.gallery_acquire vso.gallery_manage vso.graph_manage vso.identity_manage vso.loadtest_write vso.machinegroup_manage vso.memberentitlementmanagement_write vso.notification_diagnostics vso.notification_manage vso.packaging_manage vso.profile_write vso.project_manage vso.release_manage vso.securefiles_manage vso.security_manage vso.serviceendpoint_manage vso.symbols_manage vso.taskgroups_manage vso.test_write vso.tokenadministration vso.tokens vso.variablegroups_manage vso.wiki_write vso.work_full&redirect_uri={1}";
        public string redirectUrl = "https://reportgeneration.com:495/Home/Index";
        public string clientSecret = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Im9PdmN6NU1fN3AtSGpJS2xGWHo5M3VfVjBabyJ9.eyJjaWQiOiI2ZTgxNzc2ZS1jMGE3LTQ2ZjYtOTQ0OC1lY2UwMTgxOWVjN2EiLCJjc2kiOiIwZjA4NWFlMi1hYzU1LTRmNDMtODVlYy1kNjRjODQzNWNjNjYiLCJuYW1laWQiOiIzZTQxNDRkMS1hMTFiLTYwMmQtOTc0NC0wNWRiNWE2OTBjN2YiLCJpc3MiOiJhcHAudnN0b2tlbi52aXN1YWxzdHVkaW8uY29tIiwiYXVkIjoiYXBwLnZzdG9rZW4udmlzdWFsc3R1ZGlvLmNvbSIsIm5iZiI6MTU4NTgyNDMyOCwiZXhwIjoxNzQzNTkwNzI4fQ.31rvMft744BFuvdlsrE4pjeff6rmAHzRRU5qpaoKVCgDA-xjADPxq81CySw3n_6znAg1hN8z_aEB-YP83YW8HDK3yX_kklC6il5SMS1fqfPrgyCuKKzop0z7m_lTvZXFhyE53ZmxrVdITuaaoL1dF2nFvXrH3MK7FNtZSgl8n5odtsLx_bJZIjS8h-SbWiJjpzytbdxQHwvW6cM_zhVbkk8w110HONztIW70J-uxTQB2Q1TXXUnanIxs2d2ZVK7OApWEiZTD8SiRJikEjs5ML4Zw6tJym8uPh5HSdtBajp7zbiQLpxcpdb4b6CtGWOE63Yhc58zSui_a-TeR-H4z6A";
        public string clientId = "6E81776E-C0A7-46F6-9448-ECE01819EC7A";
        public string appScope = "vso.analytics vso.auditlog vso.build_execute vso.code_full vso.connected_server vso.dashboards_manage vso.entitlements vso.environment_manage vso.extension.data_write vso.extension_manage vso.gallery_acquire vso.gallery_manage vso.graph_manage vso.identity_manage vso.loadtest_write vso.machinegroup_manage vso.memberentitlementmanagement_write vso.notification_diagnostics vso.notification_manage vso.packaging_manage vso.profile_write vso.project_manage vso.release_manage vso.securefiles_manage vso.security_manage vso.serviceendpoint_manage vso.symbols_manage vso.taskgroups_manage vso.test_write vso.tokenadministration vso.tokens vso.variablegroups_manage vso.wiki_write vso.work_full";
        public string BaseAddress = "https://app.vssps.visualstudio.com/";


        //web publish

        //public string url = "https://app.vssps.visualstudio.com/oauth2/authorize?client_id={0}&response_type=Assertion&state=User1&scope=vso.analytics vso.auditlog vso.build_execute vso.code_full vso.code_status vso.dashboards_manage vso.environment_manage vso.extension.data_write vso.extension_manage vso.gallery_acquire vso.gallery_manage vso.graph_manage vso.identity_manage vso.loadtest_write vso.machinegroup_manage vso.memberentitlementmanagement_write vso.notification_diagnostics vso.notification_manage vso.packaging_manage vso.profile_write vso.project_manage vso.release_manage vso.securefiles_manage vso.security_manage vso.serviceendpoint_manage vso.symbols_manage vso.taskgroups_manage vso.test_write vso.tokenadministration vso.tokens vso.variablegroups_manage vso.wiki_write vso.work_full&redirect_uri={1}";
        //public string redirectUrl = "https://azprojecthealth.azurewebsites.net/Home/Index";
        //public string clientSecret = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Im9PdmN6NU1fN3AtSGpJS2xGWHo5M3VfVjBabyJ9.eyJjaWQiOiJjYWI5OTg0MS0xMWQ2LTQ3ODUtOWMzMy1lNDk0YWVlZTU2MTYiLCJjc2kiOiJkZWQ0YWE2Zi00NzY1LTRkZWUtYWJlMy1hMzY2OGViYTE2MmMiLCJuYW1laWQiOiIzZTQxNDRkMS1hMTFiLTYwMmQtOTc0NC0wNWRiNWE2OTBjN2YiLCJpc3MiOiJhcHAudnN0b2tlbi52aXN1YWxzdHVkaW8uY29tIiwiYXVkIjoiYXBwLnZzdG9rZW4udmlzdWFsc3R1ZGlvLmNvbSIsIm5iZiI6MTU4NjkyMjY4NCwiZXhwIjoxNzQ0Njg5MDg0fQ.2lNTN3PsEvxa3tbFKFIf6S1hFt7s6-iYxgRZqYI2t4U2c3jq-jNq3Kr-sKpUS1RtcsshCUjsFWVyTD0xXbpNMg1pMl1McDPMMqjOKIDHa38Pz2-bK3kQT-Wbi41JhBV5TL-NNV3fBPsaOfCE0viL0bOie6NEdnpAx0gNTBWMITOzFyQmFYmyAmC6311kySqddkRGjRiXrRGAymz0zdFtgz9vocjCUCF0VPXIYd_92VzgmYItP6yOFCFujYvJoUrMCdcUpOqyXl_0eBLE-akfbfBd3UPnlWXiYq8Xbsg5lbMsyoXpG_VdtLRlRv2MYYQs-JpMBHpu9MFAi2ggizs2Ow";
        //public string clientId = "CAB99841-11D6-4785-9C33-E494AEEE5616";
        //public string appScope = "vso.analytics vso.auditlog vso.build_execute vso.code_full vso.code_status vso.dashboards_manage vso.environment_manage vso.extension.data_write vso.extension_manage vso.gallery_acquire vso.gallery_manage vso.graph_manage vso.identity_manage vso.loadtest_write vso.machinegroup_manage vso.memberentitlementmanagement_write vso.notification_diagnostics vso.notification_manage vso.packaging_manage vso.profile_write vso.project_manage vso.release_manage vso.securefiles_manage vso.security_manage vso.serviceendpoint_manage vso.symbols_manage vso.taskgroups_manage vso.test_write vso.tokenadministration vso.tokens vso.variablegroups_manage vso.wiki_write vso.work_full";
        //public string BaseAddress = "https://app.vssps.visualstudio.com/";
    }
}