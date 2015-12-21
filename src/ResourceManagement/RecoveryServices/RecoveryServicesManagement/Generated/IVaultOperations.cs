// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.RecoveryServices.Models;

namespace Microsoft.Azure.Management.RecoveryServices
{
    /// <summary>
    /// Definition of vault operations for the Recovery Services extension.
    /// </summary>
    public partial interface IVaultOperations
    {
        /// <summary>
        /// Creates a vault
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the (resource group?) cloud service containing the job
        /// collection.
        /// </param>
        /// <param name='vaultName'>
        /// The name of the vault to create.
        /// </param>
        /// <param name='vaultCreationInput'>
        /// Vault object to be created
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Vm group object.
        /// </returns>
        Task<VaultCreateResponse> BeginCreatingAsync(string resourceGroupName, string vaultName, VaultCreateArgs vaultCreationInput, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes a vault
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the (Resource Group) cloud service containing the job
        /// collection.
        /// </param>
        /// <param name='vaultName'>
        /// The name of the vault to delete.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<RecoveryServicesOperationStatusResponse> BeginDeletingAsync(string resourceGroupName, string vaultName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a vault
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the (resource group) cloud service containing the job
        /// collection.
        /// </param>
        /// <param name='vaultName'>
        /// The name of the vault to create.
        /// </param>
        /// <param name='vaultCreationInput'>
        /// Vault object to be created
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<RecoveryServicesOperationStatusResponse> CreateAsync(string resourceGroupName, string vaultName, VaultCreateArgs vaultCreationInput, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes a vault
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the (Resource Group) cloud service containing the job
        /// collection.
        /// </param>
        /// <param name='vaultName'>
        /// The name of the vault to delete.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<RecoveryServicesOperationStatusResponse> DeleteAsync(string resourceGroupName, string vaultName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the Vaults.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the (resource group?) cloud service containing the
        /// vault collection.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for Vault.
        /// </returns>
        Task<VaultListResponse> GetAsync(string resourceGroupName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Fetches resource storage config.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of resource group to which vault belongs
        /// </param>
        /// <param name='resourceName'>
        /// The name of the vault
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a get resource storage config response.
        /// </returns>
        Task<GetResourceStorageConfigResponse> GetResourceStorageConfigAsync(string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates vault storage model type.
        /// </summary>
        /// <param name='updateVaultStorageTypeRequest'>
        /// Update Vault Storage Type Request
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> UpdateStorageTypeAsync(string resourceGroupName, string resourceName, UpdateVaultStorageTypeRequest updateVaultStorageTypeRequest, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}
