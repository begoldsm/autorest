/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.validation;

import com.microsoft.rest.ServiceCall;
import com.microsoft.rest.ServiceCallback;
import com.microsoft.rest.ServiceResponse;
import fixtures.validation.models.Product;
import rx.Observable;

/**
 * The interface for AutoRestValidationTest class.
 */
public interface AutoRestValidationTest {
    /**
     * The default base URL.
     */
    String DEFAULT_BASE_URL = "http://localhost";

    /**
     * Gets Subscription ID..
     *
     * @return the subscriptionId value.
     */
    String subscriptionId();

    /**
     * Sets Subscription ID..
     *
     * @param subscriptionId the subscriptionId value.
     * @return the service client itself
     */
    AutoRestValidationTest withSubscriptionId(String subscriptionId);

    /**
     * Gets Required string following pattern \d{2}-\d{2}-\d{4}.
     *
     * @return the apiVersion value.
     */
    String apiVersion();

    /**
     * Sets Required string following pattern \d{2}-\d{2}-\d{4}.
     *
     * @param apiVersion the apiVersion value.
     * @return the service client itself
     */
    AutoRestValidationTest withApiVersion(String apiVersion);

    /**
     * Validates input parameters on the method. See swagger for details.
     *
     * @param resourceGroupName Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+.
     * @param id Required int multiple of 10 from 100 to 1000.
     * @return the Product object if successful.
     */
    Product validationOfMethodParameters(String resourceGroupName, int id);

    /**
     * Validates input parameters on the method. See swagger for details.
     *
     * @param resourceGroupName Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+.
     * @param id Required int multiple of 10 from 100 to 1000.
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<Product> validationOfMethodParametersAsync(String resourceGroupName, int id, final ServiceCallback<Product> serviceCallback);

    /**
     * Validates input parameters on the method. See swagger for details.
     *
     * @param resourceGroupName Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+.
     * @param id Required int multiple of 10 from 100 to 1000.
     * @return the observable to the Product object
     */
    Observable<Product> validationOfMethodParametersAsync(String resourceGroupName, int id);

    /**
     * Validates input parameters on the method. See swagger for details.
     *
     * @param resourceGroupName Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+.
     * @param id Required int multiple of 10 from 100 to 1000.
     * @return the observable to the Product object
     */
    Observable<ServiceResponse<Product>> validationOfMethodParametersWithServiceResponseAsync(String resourceGroupName, int id);

    /**
     * Validates body parameters on the method. See swagger for details.
     *
     * @param resourceGroupName Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+.
     * @param id Required int multiple of 10 from 100 to 1000.
     * @return the Product object if successful.
     */
    Product validationOfBody(String resourceGroupName, int id);

    /**
     * Validates body parameters on the method. See swagger for details.
     *
     * @param resourceGroupName Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+.
     * @param id Required int multiple of 10 from 100 to 1000.
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<Product> validationOfBodyAsync(String resourceGroupName, int id, final ServiceCallback<Product> serviceCallback);

    /**
     * Validates body parameters on the method. See swagger for details.
     *
     * @param resourceGroupName Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+.
     * @param id Required int multiple of 10 from 100 to 1000.
     * @return the observable to the Product object
     */
    Observable<Product> validationOfBodyAsync(String resourceGroupName, int id);

    /**
     * Validates body parameters on the method. See swagger for details.
     *
     * @param resourceGroupName Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+.
     * @param id Required int multiple of 10 from 100 to 1000.
     * @return the observable to the Product object
     */
    Observable<ServiceResponse<Product>> validationOfBodyWithServiceResponseAsync(String resourceGroupName, int id);
    /**
     * Validates body parameters on the method. See swagger for details.
     *
     * @param resourceGroupName Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+.
     * @param id Required int multiple of 10 from 100 to 1000.
     * @param body the Product value
     * @return the Product object if successful.
     */
    Product validationOfBody(String resourceGroupName, int id, Product body);

    /**
     * Validates body parameters on the method. See swagger for details.
     *
     * @param resourceGroupName Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+.
     * @param id Required int multiple of 10 from 100 to 1000.
     * @param body the Product value
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<Product> validationOfBodyAsync(String resourceGroupName, int id, Product body, final ServiceCallback<Product> serviceCallback);

    /**
     * Validates body parameters on the method. See swagger for details.
     *
     * @param resourceGroupName Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+.
     * @param id Required int multiple of 10 from 100 to 1000.
     * @param body the Product value
     * @return the observable to the Product object
     */
    Observable<Product> validationOfBodyAsync(String resourceGroupName, int id, Product body);

    /**
     * Validates body parameters on the method. See swagger for details.
     *
     * @param resourceGroupName Required string between 3 and 10 chars with pattern [a-zA-Z0-9]+.
     * @param id Required int multiple of 10 from 100 to 1000.
     * @param body the Product value
     * @return the observable to the Product object
     */
    Observable<ServiceResponse<Product>> validationOfBodyWithServiceResponseAsync(String resourceGroupName, int id, Product body);

    /**
     *
     */
    void getWithConstantInPath();

    /**
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<Void> getWithConstantInPathAsync(final ServiceCallback<Void> serviceCallback);

    /**
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    Observable<Void> getWithConstantInPathAsync();

    /**
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    Observable<ServiceResponse<Void>> getWithConstantInPathWithServiceResponseAsync();

    /**
     *
     * @return the Product object if successful.
     */
    Product postWithConstantInBody();

    /**
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<Product> postWithConstantInBodyAsync(final ServiceCallback<Product> serviceCallback);

    /**
     *
     * @return the observable to the Product object
     */
    Observable<Product> postWithConstantInBodyAsync();

    /**
     *
     * @return the observable to the Product object
     */
    Observable<ServiceResponse<Product>> postWithConstantInBodyWithServiceResponseAsync();
    /**
     *
     * @param body the Product value
     * @return the Product object if successful.
     */
    Product postWithConstantInBody(Product body);

    /**
     *
     * @param body the Product value
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    ServiceCall<Product> postWithConstantInBodyAsync(Product body, final ServiceCallback<Product> serviceCallback);

    /**
     *
     * @param body the Product value
     * @return the observable to the Product object
     */
    Observable<Product> postWithConstantInBodyAsync(Product body);

    /**
     *
     * @param body the Product value
     * @return the observable to the Product object
     */
    Observable<ServiceResponse<Product>> postWithConstantInBodyWithServiceResponseAsync(Product body);

}