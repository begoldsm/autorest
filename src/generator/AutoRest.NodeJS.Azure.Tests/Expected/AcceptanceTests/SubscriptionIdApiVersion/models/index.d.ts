/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

import * as msRestAzure from 'ms-rest-azure';
exports.BaseResource = msRestAzure.BaseResource;
exports.CloudError = msRestAzure.CloudError;

/**
 * @class
 * Initializes a new instance of the SampleResourceGroup class.
 * @constructor
 * @member {string} [name] resource group name 'testgroup101'
 *
 * @member {string} [location] resource group location 'West US'
 *
 */
export interface SampleResourceGroup {
  name?: string;
  location?: string;
}

/**
 * @class
 * Initializes a new instance of the ErrorModel class.
 * @constructor
 * @member {number} [code]
 *
 * @member {string} [message]
 *
 */
export interface ErrorModel {
  code?: number;
  message?: string;
}

