<template>
    <div class="page">
        <product-details  v-if="product" :product="product" />
    </div>
</template>

<script>
import axios from 'axios'
import ProductDetails from '../components/product/Details.vue'

export default {
    name: "product",
    components: {
        ProductDetails
    },
    data () {
        return {
            product: null
        }
    },
    beforeRouteEnter(to, from, next) {
        axios.get(`/api/products/${to.params.slug}`).then(response => {
            next(vm => vm.setData(response.data))
        })
    },
    methods: {
        setData (product) {
            this.product = product
        }
    }
}
</script>

<style>

</style>
