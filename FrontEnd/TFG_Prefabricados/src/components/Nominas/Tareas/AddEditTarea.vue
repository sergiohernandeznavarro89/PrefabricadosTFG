<template>
    <div class="addEditTarea">
        <div class="row">
             <div class="col-sm-4" v-if="isEditMode">
                <v-text-field :disabled="isEditMode" label="Codigo" v-model="value.codigo"></v-text-field>
            </div>

            <div class="col-sm-4">
                <v-text-field label="Nombre*" v-model="value.nombre"></v-text-field>
            </div>
            <div class="col-sm-4">
                <v-text-field label="Precio" v-model="value.precio" suffix="€"></v-text-field>
            </div> 
            <div class="col-sm-12">
                <v-textarea no-resize clearable clear-icon="mdi-close" label="Descripcion" v-model="value.descripcion"></v-textarea>            
            </div> 
        </div>         
    </div>  
</template>

<script>
    export default {
        name: 'addEditTarea',
        
        data() {
            return {};
        }, 
        
        props: {
            value: {
                type: Object, 
                required: true, 
                default: () => {}
            },
            isEditMode: {
                type: Boolean, 
                required: true,
                default: false
            }
        },
        
        computed: { },

        created () { },   
    
        methods: { 
            
        },
    };
</script>